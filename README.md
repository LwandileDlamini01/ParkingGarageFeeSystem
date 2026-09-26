Automated Parking Garage Fee & Revenue Management System

A strong, enterprise-grade C# console application designed to process, validate, and track daily multi-car parking data. Built using high-precision financial data models and bulletproof validation architecture.

---

Key Architectural Enhancements

High-Precision Currency Architecture: Employs the `decimal` data type across all calculation engines to eliminate floating-point rounding errors common in monetary tracking systems.
Defensive Input Validation: Utilizes `int.TryParse` within controlled loop states to isolate runtime errors and defend against invalid user data entries.
Seperate Business Logic: Implements functional separation by seperating financial processing and user interface color styling into an isolated, return-driven method (DisplayHoursParked)
Nested data Analytics: Formulates clean, 0-indexed loop tracking pipelines to calculate and render distinct revenue summaries per operating cycle day.

---

Technical Stack & Paradigms

Language: C#
Design Pattern: Modular Structural Programming
Logic Controls: Multi-nested loops (`for`, `do-while`), conditional state validation, and clean functional return vectors.
Naming Standard: Follows clean, modern Microsoft C# Enterprise naming conventions (PascalCase / camelCase).

---

How It Works

1. System Initialization: Prompt and validate the global dimensions of the tracking cycle (`daysParked` and `carsParked`).
2. Sequential data Loop: Iterate through daily loops while processing distinct car sub-loops.
3. Runtime Hour Validation: Verify that hours are valid ( between 0 - 24).
4. Tiered Fee Calculation:
   Short Stay (≤ 5 Hours): Evaluated at an hourly rate of `R10.00 / hour`.
   Long Stay (> 5 Hours): Capped at a premium flat rate of `R200.00`.
5. Real-time Financial Aggregation: Aggregate calculation data into a safe, daily financial summary layout.
