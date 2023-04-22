// <auto-generated>
// This code is generated by csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
#pragma warning disable CS8500
#pragma warning disable CS8981
using System;
using System.Runtime.InteropServices;

namespace CsBindgen
{
    internal static unsafe partial class NativeMethods
    {
        const string __DllName = "libchdr";

        [DllImport(__DllName, EntryPoint = "cs_chd_open_core_file", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int chd_open_core_file(chd_core_file* file, int mode, _chd_file* parent, _chd_file** chd);

        [DllImport(__DllName, EntryPoint = "cs_chd_open_file", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int chd_open_file(_iobuf* file, int mode, _chd_file* parent, _chd_file** chd);

        [DllImport(__DllName, EntryPoint = "cs_chd_open", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int chd_open(byte* filename, int mode, _chd_file* parent, _chd_file** chd);

        [DllImport(__DllName, EntryPoint = "cs_chd_precache", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int chd_precache(_chd_file* chd);

        [DllImport(__DllName, EntryPoint = "cs_chd_close", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void chd_close(_chd_file* chd);

        [DllImport(__DllName, EntryPoint = "cs_chd_core_file", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern chd_core_file* chd_core_file(_chd_file* chd);

        [DllImport(__DllName, EntryPoint = "cs_chd_error_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern byte* chd_error_string(int err);

        [DllImport(__DllName, EntryPoint = "cs_chd_get_header", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern _chd_header* chd_get_header(_chd_file* chd);

        [DllImport(__DllName, EntryPoint = "cs_chd_read_header", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int chd_read_header(byte* filename, _chd_header* header);

        [DllImport(__DllName, EntryPoint = "cs_chd_read", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int chd_read(_chd_file* chd, uint hunknum, void* buffer);

        [DllImport(__DllName, EntryPoint = "cs_chd_get_metadata", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int chd_get_metadata(_chd_file* chd, uint searchtag, uint searchindex, void* output, uint outputlen, uint* resultlen, uint* resulttag, byte* resultflags);

        [DllImport(__DllName, EntryPoint = "cs_chd_codec_config", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int chd_codec_config(_chd_file* chd, int param, void* config);

        [DllImport(__DllName, EntryPoint = "cs_chd_get_codec_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern byte* chd_get_codec_name(uint codec);


    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct _iobuf
    {
        public void* _Placeholder;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct chd_core_file
    {
        public void* argp;
        public delegate* unmanaged[Cdecl]<chd_core_file*, ulong> fsize;
        public delegate* unmanaged[Cdecl]<void*, nuint, nuint, chd_core_file*, nuint> fread;
        public delegate* unmanaged[Cdecl]<chd_core_file*, int> fclose;
        public delegate* unmanaged[Cdecl]<chd_core_file*, long, int, int> fseek;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct _chd_file
    {
        public fixed byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct _chd_header
    {
        public uint length;
        public uint version;
        public uint flags;
        public fixed uint compression[4];
        public uint hunkbytes;
        public uint totalhunks;
        public ulong logicalbytes;
        public ulong metaoffset;
        public ulong mapoffset;
        public fixed byte md5[16];
        public fixed byte parentmd5[16];
        public fixed byte sha1[20];
        public fixed byte rawsha1[20];
        public fixed byte parentsha1[20];
        public uint unitbytes;
        public ulong unitcount;
        public uint hunkcount;
        public uint mapentrybytes;
        public byte* rawmap;
        public uint obsolete_cylinders;
        public uint obsolete_sectors;
        public uint obsolete_heads;
        public uint obsolete_hunksize;
    }



}
    