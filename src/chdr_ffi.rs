/* automatically generated by csbindgen */

#[allow(unused)]
use ::std::os::raw::*;

use super::chd::*;


#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_open_core_file(
    file: *mut core_file,
    mode: c_int,
    parent: *mut chd_file,
    chd: *mut *mut chd_file    
) -> chd_error
{
    chd_open_core_file(
        file,
        mode,
        parent,
        chd
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_open_file(
    file: *mut FILE,
    mode: c_int,
    parent: *mut chd_file,
    chd: *mut *mut chd_file    
) -> chd_error
{
    chd_open_file(
        file,
        mode,
        parent,
        chd
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_open(
    filename: *const c_char,
    mode: c_int,
    parent: *mut chd_file,
    chd: *mut *mut chd_file    
) -> chd_error
{
    chd_open(
        filename,
        mode,
        parent,
        chd
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_precache(
    chd: *mut chd_file    
) -> chd_error
{
    chd_precache(
        chd
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_close(
    chd: *mut chd_file    
)
{
    chd_close(
        chd
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_core_file(
    chd: *mut chd_file    
) -> *mut core_file
{
    chd_core_file(
        chd
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_error_string(
    err: chd_error    
) -> *const c_char
{
    chd_error_string(
        err
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_get_header(
    chd: *mut chd_file    
) -> *const chd_header
{
    chd_get_header(
        chd
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_read_header(
    filename: *const c_char,
    header: *mut chd_header    
) -> chd_error
{
    chd_read_header(
        filename,
        header
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_read(
    chd: *mut chd_file,
    hunknum: UINT32,
    buffer: *mut c_void    
) -> chd_error
{
    chd_read(
        chd,
        hunknum,
        buffer
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_get_metadata(
    chd: *mut chd_file,
    searchtag: UINT32,
    searchindex: UINT32,
    output: *mut c_void,
    outputlen: UINT32,
    resultlen: *mut UINT32,
    resulttag: *mut UINT32,
    resultflags: *mut UINT8    
) -> chd_error
{
    chd_get_metadata(
        chd,
        searchtag,
        searchindex,
        output,
        outputlen,
        resultlen,
        resulttag,
        resultflags
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_codec_config(
    chd: *mut chd_file,
    param: c_int,
    config: *mut c_void    
) -> chd_error
{
    chd_codec_config(
        chd,
        param,
        config
    )
}

#[no_mangle]
pub unsafe extern "C" fn csbindgen_chd_get_codec_name(
    codec: UINT32    
) -> *const c_char
{
    chd_get_codec_name(
        codec
    )
}

    