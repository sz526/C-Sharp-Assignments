using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Spectre.Console;

namespace AssignmentOverloading
{
    public class Calculator
    {
        // Overload A: Handles two integers
        public double Add(int a, int b)
        {
            AnsiConsole.MarkupLine("[grey]Using overload: (int, int)[/]");
            return a + b;
        }

        // Overload B: Handles two doubles
        public double Add(double a, double b)
        {
            AnsiConsole.MarkupLine("[grey]Using overload: (double, double)[/]");
            return a + b;
        }

        // Overload C: Handles a list of numbers
        public double Add(List<double> numbers)
        {
            AnsiConsole.MarkupLine($"[grey]Using overload: (List<double>) with {numbers.Count} items[/]");
            return numbers.Sum();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalc = new Calculator();
            bool isRunning = true;

            AnsiConsole.Write(new Rule("[yellow]Advanced Overloading Calculator[/]"));

            while (isRunning)
            {
                string input = AnsiConsole.Ask<string>("\nEnter numbers (split by comma or space, or type 'exit'): ");

                if (input.ToLower() == "exit") break;

                // Parse input
                char[] delimiters = { ',', ' ' };
                string[] parts = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                
                List<double> numbers = new List<double>();
                foreach (var part in parts)
                {
                    //if (double.TryParse(part, out double num))
                     if (double.TryParse(part, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                        numbers.Add(num);
                   
    
                }

                if (numbers.Count < 2)
                {
                    AnsiConsole.MarkupLine("[red]Error: Please enter at least two numbers![/]");
                    continue;
                }

                // Choose the correct overload based on input count
                double result = numbers.Count == 2 ? myCalc.Add(numbers[0], numbers[1]) : myCalc.Add(numbers);

                AnsiConsole.Write(new Panel($"Result: [bold green]{result}[/]").Border(BoxBorder.Rounded));
            }
        }
    }
}
