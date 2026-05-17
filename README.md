# DSAAdvance

A personal practice repository for **Data Structures, Algorithms, and OOP concepts** written in **C# (.NET 8)**.

Each problem lives in its **own file** under a topic-based subfolder, with a header comment that names the LeetCode/GFG problem and gives a short approach summary. This way, when I come back later, I can find a problem by topic and understand it without reading code.

---

## Tech Stack

- **Language:** C# 12
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022

---

## Project Structure

```
DSAAdvance/
│
├── Array/
│   ├── Sum/                    # Sum-target problems
│   │   ├── TwoSum.cs           (LC #1)
│   │   ├── ThreeSum.cs         (LC #15)
│   │   ├── FourSum.cs          (LC #18)
│   │   └── CountQuadruplets.cs (LC #1995)
│   │
│   ├── Matrix/                 # 2D matrix problems
│   │   ├── SpiralMatrix.cs     (LC #54)
│   │   └── RotateImage.cs      (LC #48)
│   │
│   ├── Sorting/                # Sorting algorithms
│   │   ├── SortColors.cs       (LC #75 - Dutch National Flag)
│   │   ├── InsertionSort.cs
│   │   └── MergeSort.cs        (+ Number of Inversions)
│   │
│   ├── Search/                 # Search problems
│   │   ├── BinarySearchRecursive.cs
│   │   ├── SearchRange.cs      (LC #34)
│   │   └── SingleNonDuplicate.cs (LC #540)
│   │
│   ├── Majority/               # Boyer-Moore Voting
│   │   ├── MajorityElement.cs   (LC #169)
│   │   └── MajorityElementII.cs (LC #229)
│   │
│   └── Misc/                   # Single-method utilities
│       ├── RemoveDuplicates.cs   (LC #26)
│       ├── RotateArray.cs        (LC #189)
│       ├── MaxConsecutiveOnes.cs (LC #485)
│       ├── SingleNumber.cs       (LC #136)
│       ├── ReverseInteger.cs     (LC #7)
│       ├── PalindromeNumber.cs   (LC #9)
│       ├── IntersectionArray.cs  (LC #349)
│       ├── UnionArray.cs         (GFG)
│       ├── Leaders.cs            (GFG)
│       ├── SecondLargest.cs      (GFG)
│       ├── MissingRepeating.cs   (GFG)
│       ├── BinomialCoefficient.cs
│       └── PrintRecursive.cs
│
├── BinarySearch/
│   ├── OnAnswer/               # Binary search on the answer
│   │   ├── AggressiveCows.cs   (SPOJ AGGRCOW)
│   │   ├── BookAllocation.cs   (GFG)
│   │   ├── KokoEatingBananas.cs (LC #875)
│   │   ├── SmallestDivisor.cs  (LC #1283)
│   │   ├── RoseGarden.cs       (LC #1482)
│   │   ├── NthRoot.cs          (GFG)
│   │   └── FloorSqrt.cs        (LC #69)
│   │
│   ├── Sorted/                 # Binary search on sorted arrays
│   │   ├── SingleNonDuplicate.cs (LC #540)
│   │   └── FloorAndCeil.cs       (GFG)
│   │
│   └── Rotated/                # Rotated sorted arrays
│       ├── FindKRotation.cs    (GFG)
│       └── SearchInRotatedSortedArrayII.cs (LC #81)
│
├── Basic/                      # C# / OOP fundamentals
│   ├── Basic.cs                (shallow vs deep copy demo)
│   └── BasicOops.cs            (interface implementation demo)
│
├── designPatterns/             # GoF design patterns
│   ├── factoryPattern.cs       (Factory)
│   └── singalTon.cs            (Singleton, thread-safe double-checked locking)
│
├── Program.cs                  # Entry point + scratchpad
├── DSAAdvance.csproj
└── DSAAdvance.sln
```

---

## Naming Convention

Every problem class has:
- A **`Solve()` method** as the main entry (sometimes `SolveBrute()`, `SolveAlt()` for alternates).
- A **header comment** with the LeetCode/GFG problem number and a one-line description.
- A **complexity note** (Time/Space) in the comment.
- Old attempts kept as **commented-out blocks** for reference.

Example:
```csharp
// LeetCode #1 - Two Sum
// Given nums[] and target, return indices of two numbers that add up to target.
public class TwoSum
{
    // HashMap approach - Time O(n), Space O(n)
    public int[] Solve(int[] nums, int target) { ... }

    // Brute Force approach - Time O(n^2), Space O(1)
    public List<int> SolveBrute(List<int> nums, int target) { ... }
}
```

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

The entry point is `Program.cs` → `DSAAdvance.Program.Main()`. By default it runs a Two Sum smoke test. Uncomment any other line in `Main()` to run that demo.

---

## How I add a new problem

1. Pick the right topic folder (or create one).
2. Create `ProblemName.cs` with the header comment + `Solve()` method.
3. Add a quick test call in `Program.cs` `Main()` if I want to run it.

---

## Topics covered so far

- [x] Arrays — Two Sum, 3Sum, 4Sum, Sort Colors, Rotate Array, Majority Elements, Spiral Matrix, Rotate Image
- [x] Binary Search — basic + binary-search-on-the-answer (Koko Bananas, Book Allocation, Aggressive Cows)
- [x] Sorting — Insertion Sort, Merge Sort (+ inversion count)
- [x] OOP — shallow vs deep copy, interfaces
- [x] Design Patterns — Factory, Singleton

## Topics to add next

- [ ] Linked List
- [ ] Stack & Queue
- [ ] Recursion / Backtracking
- [ ] Sliding Window
- [ ] Dynamic Programming
- [ ] Trees & Graphs
- [ ] String problems
- [ ] Greedy

---

## Author

**Amrish Kumar** — learning DSA in C#, one problem at a time.
