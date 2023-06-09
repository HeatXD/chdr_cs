use std::process::Command;

extern crate bindgen;
extern crate csbindgen;

fn main() {
    // load chd.h and output rust bindgen to chd.rs
    bindgen::Builder::default()
        .clang_args(&["-I./thirdparty/libchdr/include"])
        .header("thirdparty/libchdr/include/libchdr/chd.h")
        .generate()
        .unwrap()
        .write_to_file("src/chd.rs")
        .unwrap();
    // load bindgen code and generate c# code
    csbindgen::Builder::default()
        .input_bindgen_file("src/chd.rs")
        .method_filter(|x| x.starts_with("chd_"))
        .rust_file_header("use super::chd::*;")
        .csharp_entry_point_prefix("csbindgen_")
        .csharp_dll_name("libchdr_cs")
        .generate_to_file("src/chdr_ffi.rs", "gen/chdr.cs")
        .unwrap();
    // build the c code with cmake
    Command::new("cmake")
        .args(&["-S","thirdparty/libchdr","-B","gen/build"])
        .status()
        .unwrap();

    Command::new("cmake")
        .args(&["--build","gen/build","--config","Release"])
        .status()
        .unwrap();

    println!("cargo:rustc-link-lib=gen/build/deps/lzma-22.01/Release/lzma");     
    println!("cargo:rustc-link-lib=dylib=/build/deps/zlib-1.2.12/Release/zlib-1");
    println!("cargo:rustc-link-lib=dylib=gen/build/Release/chdr");
}
