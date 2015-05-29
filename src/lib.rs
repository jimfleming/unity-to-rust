#[no_mangle]
pub extern fn double_input(input: i32) -> i32 {
    input * 2
}

#[no_mangle]
pub extern fn triple_input(input: i32) -> i32 {
    input * 3
}
