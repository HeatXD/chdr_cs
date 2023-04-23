using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using CsBindgen;

using NM = CsBindgen.NativeMethods;

namespace CHDRTEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! args: {0}", args.Length != 0 ? string.Join(", ", args) : "none");
            if (args.Length == 0) return;
            NativeTest(args[0]);
        }

        static unsafe void NativeTest(string filepath)
        {

            Stopwatch stopWatch = new();

            int err;

            _chd_file* file;
            _chd_header* header;

            IntPtr buffer;
            uint i;
            uint totalbytes;

            var path = Encoding.GetEncoding("utf-8").GetBytes(filepath);

            stopWatch.Start();

            fixed (byte* fpath = path)
            {
                err = NM.chd_open(fpath, 1, null, &file);
                string? p = Marshal.PtrToStringUTF8((IntPtr)fpath);
                Console.WriteLine("path: {0}", p);
            }

            if (err != 0)
            {
                string? error = Marshal.PtrToStringUTF8((IntPtr)NM.chd_error_string(err));
                Console.WriteLine("Error: {0}", error);
            }

            header = NM.chd_get_header(file);
            totalbytes = header->hunkbytes * header->totalhunks;
            buffer = Marshal.AllocHGlobal((int)header->hunkbytes);

            for (i = 0; i < header->totalhunks; i++)
            {
                err = NM.chd_read(file, i, buffer.ToPointer());
                if (err != 0)
                {
                    string? error = Marshal.PtrToStringAuto((IntPtr)NM.chd_error_string(err));
                    Console.WriteLine("Error: {0}", err);
                }
            }

            Marshal.FreeHGlobal(buffer);
            NM.chd_close(file);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}.{1:000}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine("RunTime: {0} seconds", elapsedTime);
            Console.WriteLine("Read: {0} bytes in {1} seconds", totalbytes, elapsedTime);
            Console.WriteLine("Rate is {0} MB/s", (Convert.ToDouble(totalbytes) / (1024 * 1024)) / ts.TotalSeconds);
        }
    }
}