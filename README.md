# KataPractice · TDD & Clean Code Playground

A structured repository for daily **TDD-based coding katas** designed to strengthen Clean Code habits, design thinking, and commit discipline using the classic **Red-Green-Refactor** pattern.


---

## 🎯 Philosophy

This repository serves as a personal gym for software craftsmanship. The core principles are:

- **Discipline through Practice**: Short, daily katas (~15-30 mins) to build TDD muscle memory.
- **Traceable Progress**: Each step of the TDD cycle—`RED`, `GREEN`, `REFACTOR`—is a distinct commit, creating a transparent and reviewable history.
- **Structured Learning**: Katas are organized by complexity, and each has its own dedicated solution to keep the focus clean and modular.
- **Living Journal**: Commit messages and reflections act as a log of insights and learning over time.

## 🚀 Getting Started: The Kata Workflow

To add a new kata, follow these steps:

1. **Create a Directory**: Make a new top-level folder for the kata (e.g., `StringCalculator/`).
2. **Set Up Projects**: Inside the new directory, create separate projects for the implementation and the tests.
3. **Follow RGRC**: Adhere strictly to the Red-Green-Refactor-Commit cycle.
4. **Update the Directory**: Add an entry for the new kata in the table below.

## ✅ Commit Convention: RGRC (Red-Green-Refactor-Commit)

This verbose commit style makes the TDD process fully traceable in the git history.

| Prefix       | Purpose                                                                             |
|--------------|-------------------------------------------------------------------------------------|
| `[RED]`      | Add a failing test that defines a new piece of desired behavior.                    |
| `[GREEN]`    | Write the simplest possible code to make the failing test pass.                     |
| `[REFACTOR]` | Improve the internal structure of the code without changing its external behavior.  |
| `[COMMIT]`   | Perform administrative tasks (e.g., update README, configure CI, add `.gitignore`). |

*Practicing this pattern enforces clarity, discipline, and helps track TDD phases in your version history.*

---

## 📚 Kata Directory

This table tracks the katas included in this repository.

| Status | Kata                         | Level   |
|:------:|:-----------------------------|:--------|
|   ✅    | FizzBuzz                     | Level 1 |
|   📝   | FizzBuzz - Rule-Based        | Level 1 |
|   📝   | FizzBuzz - Functional Rules  | Level 1 |
|   📝   | FizzBuzz - Multithreaded     | Level 1 |
|   📝   | FizzBuzz - High Performance  | Level 1 |
|   📝   | FizzBuzz - SIMD / Branchless | Level 1 |
|   📝   | FizzBuzz - Compile-Time      | Level 1 |

### Legend

- ✅: Completed
- 🚧: In Progress
- 📝: Planned / Not Started

### Kata description

#### FizzBuzz - Rule-Based

Implement FizzBuzz using a rule-based pipeline instead of traditional `if` statements. The goal is to create a system where each rule is independent, reusable, and testable.

**Core Requirements**

- **Input**: A number `n` within a given range (e.g., 1 to 100).
- **Output**:
    - If one or more rules match, concatenate their replacement strings (e.g., `15` becomes `"FizzBuzz"`).
    - If no rules match, return the number as a string (e.g., `7` becomes `"7"`).

**Rule Definition**

Each rule must be an object or function that:

1. Defines a condition: `bool Matches(int number)`
2. Provides a replacement string.

**Initial Rule Set**

| Condition              | Replacement |
|------------------------|-------------|
| Divisible by 3         | `"Fizz"`    |
| Divisible by 5         | `"Buzz"`    |
| Contains the digit `3` | `"Fizz"`    |
| Contains the digit `5` | `"Buzz"`    |

**Design Constraints**

- **Extensibility**: New rules must be addable without modifying existing code.
- **Composition**: Use object-oriented or functional composition to build the pipeline.
- **Engine**: The main FizzBuzz engine should apply all rules in sequence and assemble the final output.

---

#### FizzBuzz - Functional Rules

Implement FizzBuzz using **pure functional composition**. The focus is on building small, side-effect-free rule functions and combining them declaratively.

**Core Requirements**

* **Input**: A number `n` within a given range (e.g., 1 to 100).
* **Output**:

    * Combine the results of all matching rule functions into a single output string.
    * If no rules match, return the number as a string.

**Rule Definition**

Each rule is a pure function of type:
`Func<int, string?>`
The function returns either a string (e.g., `"Fizz"`) or `null`/empty if the rule does not apply.

**Initial Rule Set**

Same as in the Rule-Based variant:

* Divisible by 3 → `"Fizz"`
* Divisible by 5 → `"Buzz"`
* Contains 3 → `"Fizz"`
* Contains 5 → `"Buzz"`

**Design Constraints**

* **Purity**: All rules must be stateless and side-effect free.
* **Composition**: Combine rules using `map` / `filter` / `aggregate` operations.
* **Testability**: Each rule can be unit tested in isolation.
* **Immutability**: Avoid mutating shared state or global variables.

---

#### FizzBuzz - Multithreaded

Implement FizzBuzz where each rule is processed in **its own thread or task**, and the final output is produced in the correct sequence.

**Core Requirements**

* **Input**: A number `n` within a given range.
* **Output**:

    * Apply all rules in parallel for each number.
    * Combine results in the correct order and return a complete ordered output (e.g., from 1 to 100).

**Rule Definition**

Each rule is executed in a separate thread or task, evaluating one number at a time or working across a stream of numbers.

**Initial Rule Set**

Same conditions and replacements as previous variants.

**Design Constraints**

* **Correctness**: Ensure the final result maintains the original order of numbers.
* **Concurrency**: Use threads, tasks, or message queues to parallelize rule evaluation.
* **Robustness**: Faulty rules must not crash the entire pipeline.
* **Testability**: Include tests for race conditions, ordering, and error handling.

---

#### FizzBuzz - High Performance

Implement FizzBuzz optimized for very large ranges (e.g., up to 10 million). Focus on **I/O-efficient output and memory-friendly design**.

**Core Requirements**

* **Input**: A large number range (e.g., 1 to 10,000,000).
* **Output**:

    * Generate all FizzBuzz results efficiently.
    * Avoid slow I/O operations like `Console.WriteLine` per number.

**Rule Definition**

Same rules as in the basic version, but designed to run with minimal branching and allocations.

**Design Constraints**

* **Buffering**: Output should be written to a memory buffer or file stream.
* **Minimizing Modulo**: Avoid unnecessary `%` operations.
* **Throughput**: Measure runtime performance and memory usage.
* **Benchmarking**: Include profiling tools or timing metrics to validate performance improvements.

---

#### FizzBuzz - SIMD / Branchless

Implement FizzBuzz using a **SIMD-enabled**, branchless approach that processes multiple numbers in parallel for maximum throughput.

**Core Requirements**

* **Input**: A number range (e.g., 1 to 1,000,000).
* **Output**:

    * Process numbers in fixed-size blocks using precomputed rules.
    * Output must be correct and ordered.

**Rule Definition**

Rules are applied using lookup tables, vector operations (e.g., `Vector<int>`), or branchless pattern-matching techniques.

**Design Constraints**

* **Branch Elimination**: Avoid `if` statements; use table lookups or arithmetic.
* **Vectorization**: Use .NET SIMD (`System.Numerics.Vector<T>`) or similar techniques.
* **Chunking**: Process outputs in 15-number blocks when possible.
* **Performance Testing**: Target extreme throughput (e.g., GB/s).

---

#### FizzBuzz - Compile-Time

Implement FizzBuzz entirely at **compile-time**, using language features such as `constexpr`, `const fn`, or generics with type-level logic.

**Core Requirements**

* **Input**: A fixed range of integers known at compile time.
* **Output**:

    * Generate the FizzBuzz result as a compile-time constant.
    * Include static assertions to verify correctness.

**Rule Definition**

Rules are encoded as template logic or evaluated in compile-time functions.

**Design Constraints**

* **No Runtime Logic**: The entire output must be computed before execution.
* **Static Testing**: Use `static_assert` or equivalent to test specific values.
* **Language Features**: Use C++ `constexpr`, Rust `const fn`, or similar.
