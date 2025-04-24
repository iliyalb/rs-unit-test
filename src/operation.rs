// Module
use crate::error::Error;

pub fn add(operand_x: i32, operand_y: i32) -> Result<i32, Error> {
    if operand_x < 0 || operand_y < 0 {
        return Err(Error::Generic("Operands must be non-negative".to_string()));
    }
    Ok(operand_x + operand_y)
}

// Unit tests
#[cfg(test)]
mod tests {
    use crate::error::Error;
    use crate::operation::add;

    #[test]
    fn test_add() {
        let result = add(2, 3);
        assert_eq!(result, Ok(5));
    }

    #[test]
    fn test_add_not_equal() {
        let result = add(2, 3);
        assert_ne!(
            result,
            Err(Error::Generic("Operands must be non-negative".to_string()))
        );
    }
}
