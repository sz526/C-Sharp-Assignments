Et program som sjekker hvor mange produkter en butikk har av en vare, og skriver ut hvor mye rabatt varen skal få basert på beholdningen.
# Assignment 1: Inventory Discount System

## 1. Planning (Pseudocode)
1. Display a welcome message to the user.
2. Prompt the user to enter the stock quantity of a product.
3. Read the user input and attempt to convert it to an integer.
4. **IF** the input is not a number:
    - Display an error message.
5. **ELSE IF** stock >= 100:
    - Set discount to 50%.
6. **ELSE IF** stock >= 50:
    - Set discount to 30%.
7. **ELSE IF** stock >= 10:
    - Set discount to 10%.
8. **ELSE** (stock < 10):
    - Set discount to 0%.
9. Output the stock status and the calculated discount percentage to the terminal.

## 2. Test Values and Results
### no object edition
To ensure the program logic works correctly, I tested the following scenarios:

| Test Input | Expected Outcome | Logic Path Tested |
| :--- | :--- | :--- |
| `150` | 50% Discount | `if (stock >= 100)` |
| `75` | 30% Discount | `else if (stock >= 50)` |
| `25` | 10% Discount | `else if (stock >= 10)` |
| `5` | No Discount | `else if (stock >= 0)` |
| `-10` | Error Message | `else` (Negative check) |
| `abc` | Invalid Input | `int.TryParse` Failure |

### Test Cases (Object-Based)
I initialized the `Product` class with different values to test the logic:

| Product Name | Input Stock | Price | Expected Discount |
| :--- | :--- | :--- | :--- |
| Laptop | 120 | 5000 | 50% (Clearance) |
| Phone | 60 | 3000 | 30% (Seasonal) |
| Mouse | 5 | 200 | 0% (Low Stock) |

### User Interaction
The program now supports dynamic user input. 
Example sequence:
1. User enters "Mechanical Keyboard"
2. User enters "1200" (Price)
3. User enters "110" (Stock) -> Logic triggers 50% discount.


## 3. How to Run (Local)
Since I am working in a restricted IT environment, I use the following commands:
1. `dotnet build`
2. `dotnet exec bin/Debug/net10.0/oppgave1.dll`