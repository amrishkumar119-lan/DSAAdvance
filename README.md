# DSAAdvance

A personal practice repository for **Data Structures, Algorithms, and OOP concepts** written in **C# (.NET 8)**.

This repo is where I solve problems topic-by-topic — arrays, binary search, patterns, basic OOP, and a few design patterns — as I work through them. Old attempts are kept as commented-out code so I can revisit my thinking later.

---

## Tech Stack

- **Language:** C# 12
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022

---

## Project Structure

```
DSAAdvance/
├── Array/              # Array problems (Two Sum, basic array operations, etc.)
│   ├── ArraySam.cs
│   └── BasicArray.cs
│
├── Basic/              # C# basics and OOP fundamentals
│   ├── Basic.cs
│   └── BasicOops.cs
│
├── BinarySearch/       # Binary search problems and logic building
│   └── LogicBuild.cs
│
├── Pattern/            # Star / number pattern printing problems
│
├── designPatterns/     # Common design patterns (GoF)
│   ├── factoryPattern.cs
│   └── singalTon.cs
│
├── Program.cs          # Main entry point (sandbox for trying problems)
├── DSAAdvance.csproj   # Project file
└── DSAAdvance.sln      # Solution file
```

### What's in each folder

| Folder | What it covers |
|--------|----------------|
| **Array** | Common array interview questions — Two Sum (using dictionary), array traversal, search, sort variations. |
| **Basic** | C# fundamentals + OOP basics (classes, objects, methods). Useful as a refresher. |
| **BinarySearch** | Binary search implementations and problems where binary search logic is applied. |
| **Pattern** | Printing patterns using loops (stars, numbers, pyramids). |
| **designPatterns** | Real implementations of design patterns — currently **Factory** and **Singleton**. The solution's startup object lives here. |
| **Program.cs** | Scratchpad `Main()` — I uncomment whichever problem I'm currently working on. |

---

## How to Run

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (or VS Code with the C# extension)

### Run from terminal

```bash
dotnet build
dotnet run
```

### Run from Visual Studio
Open `DSAAdvance.sln` and press **F5**.

> **Note:** The startup object is set to `DSAAdvance.designPatterns.program` in the `.csproj`. If you want `Program.cs` (`Programs.Main`) to run instead, edit `DSAAdvance.csproj` and change/remove the `<StartupObject>` line.

---

## How I use this repo

1. Pick a topic folder (e.g., `Array/`).
2. Add a new method for the problem I'm solving.
3. Call it from `Program.cs` `Main()` to test it.
4. Keep older approaches as commented code so I can compare them later.

---

## Topics covered so far

- [x] Two Sum (HashMap approach)
- [x] Array basics
- [x] Binary search logic building
- [x] Pattern printing (loops)
- [x] OOP fundamentals
- [x] Factory pattern
- [x] Singleton pattern

## Topics to add next

- [ ] Linked List
- [ ] Stack & Queue
- [ ] Recursion / Backtracking
- [ ] Sliding Window
- [ ] Dynamic Programming
- [ ] Trees & Graphs

---

## Author

**Amrish Kumar** — learning DSA in C#, one problem at a time.
