use rs_unit_test::{error, operation};

fn main() -> std::result::Result<(), error::Error> {
    let result = operation::add(5, 10)?;
    println!("Result: {}", result);
    Ok(())
}
