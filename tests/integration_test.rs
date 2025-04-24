use rs_unit_test::error::Error;
use std::io;

#[test]
fn test_generic_error() {
    let error = Error::Generic("Something went wrong".to_string());
    assert_eq!(error, Error::Generic("Something went wrong".to_string()));
    assert_ne!(error, Error::Generic("Another error".to_string()));
}

#[test]
fn test_partial_eq_impl() {
    let error1 = Error::Generic("Something went wrong".to_string());
    let error2 = Error::Generic("Something went wrong".to_string());
    let error3 = Error::Generic("Another error".to_string());
    let io_error1 = io::Error::new(io::ErrorKind::NotFound, "File not found");
    let io_error2 = io::Error::new(io::ErrorKind::NotFound, "File not found");

    assert_eq!(error1, error2);
    assert_ne!(error1, error3);
    assert_eq!(Error::IO(io_error1), Error::IO(io_error2));
}
