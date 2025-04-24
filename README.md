# Rust Unit Test Template

## About

A template project with:

- Custom function error logging with result returns in `src/error/mod.rs`
- Module unit tests in `src/operation.rs`
- Integration testing through `src/lib.rs` in `tests/integration_test.rs`

## Tests

For unit tests:

```sh
cargo build && cargo test --quiet
```

For integration tests:

```sh
cargo test --test integration_test
```

## License

This is free and unencumbered software released into the public domain under The Unlicense.

Anyone is free to copy, modify, publish, use, compile, sell, or distribute this software, either in source code form or as a compiled binary, for any purpose, commercial or non-commercial, and by any means.

See [UNLICENSE](LICENSE) for full details.
