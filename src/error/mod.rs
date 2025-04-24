//! Crate error
use std::io::Error as IoError;

pub mod prelude;

#[derive(thiserror::Error, Debug)]
pub enum Error {
    #[error("Generic error {0}")]
    Generic(String),

    #[error(transparent)]
    IO(#[from] IoError),
}

impl PartialEq for Error {
    fn eq(&self, other: &Self) -> bool {
        match (self, other) {
            (Error::Generic(a), Error::Generic(b)) => a == b,
            (Error::IO(a), Error::IO(b)) => a.to_string() == b.to_string(),
            _ => false,
        }
    }
}
