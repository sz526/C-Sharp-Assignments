# Module 1: C# Fundamentals

## Week 3: Method Overloading & Calculator

### Assignment Description
> "Design and implement a program that demonstrates methods with different overloads. The program should call the correct methods based on user input (e.g., a calculator)."

**Core Requirements:**
- [x] Create a modeled class with overloaded methods.
- [x] Handle different data types (int, double, or List).
- [x] Implement a loop to keep the program running.
- [x] Parse user input using delimiters like commas or spaces.

---

### Pseudocode
To solve this, I structured the logic as follows:
```text
START
    Define Calculator class with 3 Add() overloads
    Loop until user types 'exit'
        Read input string
        Split string by ',' or ' '
        Convert parts to Double
        If 2 numbers -> Call Add(num1, num2)
        If >2 numbers -> Call Add(List)
    End Loop
END
```
### Challenges & Troubleshooting

**The "Decimal Comma" Issue (Localization):**
During testing on a system with Norwegian regional settings, I encountered an issue where `double.TryParse` expected a comma (`,`) as the decimal separator, while the user input used a dot (`.`). 

- **Problem:** Input like `9.99` was either parsed incorrectly or caused the counter to fail because the comma was also used as a delimiter for the `Split()` method.
- **Solution:** I implemented `CultureInfo.InvariantCulture` within the `TryParse` method. This forces the program to consistently recognize the dot (`.`) as the decimal separator, regardless of the host computer's language settings.

> "In this assignment, you will model a class that demonstrates methods with different overloads , and design a program flow that calls the correct methods based on user input.
Suggested program idea
A natural example might be to create a calculator program that:
Ask the user what operation they want to perform (e.g. addition, subtraction, multiplication, division).
Prompts the user to enter the data on which the operation should be performed.
Performs the operation by calling the appropriate overload of a method.
To make it more interesting, you can:
Give the user the ability to enter multiple numbers in the same input.
Choose a delimiter (e.g. comma or space) to separate the numbers.
Parse the input string and convert the numbers to the correct data type ( int, doubleetc.) before running the operation.
Tips for expansion
While-loop : Let the program run continuously until the user chooses to terminate it.
Overloads : Define methods with the same name but different parameter lists – e.g. one version that takes two numbers, and another that takes a list of numbers.
Parsing and string manipulation : Explore methods in System.String(like .Split()) and conversion with int.Parse()or double.TryParse().
Collections : Consider using List<T>or arrays to handle multiple numbers dynamically.
Working method
Draw a flowchart that shows how the user's input leads to calls to the different overloads.
Write pseudocode that describes the logic step by step.
Implement the program in C#.
You are free to create a solution other than a calculator, as long as you demonstrate:
a modeled class
overloading of methods
and a clear program flow based on user input.
Good luck – and feel free to think about how you can expand the program beyond the most basic!"