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

| Status | Kata              | Level   |
|:------:|:------------------|:--------|
|   📝   | FizzBuzz          | Level 1 |
|   📝   | Leap Year         | Level 1 |
|   📝   | String Calculator | Level 1 |

### Legend

- ✅: Completed
- 🚧: In Progress
- 📝: Planned / Not Started