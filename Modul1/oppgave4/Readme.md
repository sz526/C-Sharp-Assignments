# Module 1 - Assignment 4: Pokemon CSV & LINQ

##  Assignment Description
> The goal is to build a C# application that loads a dataset from a CSV file, maps it to a custom object model, and executes advanced data queries using LINQ.

##  Pseudocode
```text
START
    1. CREATE a "Pokemon" class to represent a row (ID, Name, Type, Stats, etc.)
    2. INITIALIZE "PokemonReader" with the path to "Pokemon.csv"
    3. INSIDE Reader:
        a. READ file using File.ReadAllLines()
        b. SKIP header row
        c. FOR EACH row:
            i. SPLIT line by comma
            ii. CONVERT strings to appropriate types (int, bool, string)
            iii. MAP to Pokemon object and add to list
        d. RETURN the populated List
    4. INSIDE Program (Controller):
        a. CALL Reader to get the data
        b. QUERY: Filter where 'Legendary' is true AND 'Attack' > 120
        c. QUERY: Select only unique names of 'Type 1'
        d. QUERY: Sort by 'Speed' descending
        e. DISPLAY the results in the console
END