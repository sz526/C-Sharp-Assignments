using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var reader = new PokemonReader();
        var pokedex = reader.LoadFromCsv("Pokemon.csv");

        // 1. Select() - Get all Pokemon names
        var names = pokedex.Select(p => p.Name).Take(10); 

        // 2. Where() - Filter Legendary Pokemon with high attack
        var strongLegendaries = pokedex.Where(p => p.Legendary && p.Attack > 120);

        // 3. OrderBy() - Sort by Speed
        var fastest = pokedex.OrderByDescending(p => p.Speed).First();

        // 4. Distinct() - Find all unique primary types
        var uniqueTypes = pokedex.Select(p => p.Type1).Distinct();

        // Print Results
        Console.WriteLine($"Fastest Pokemon: {fastest.Name} (Speed: {fastest.Speed})");
        Console.WriteLine("\nStrong Legendaries:");
        foreach (var p in strongLegendaries)
        {
            Console.WriteLine($"- {p.Name} (ATK: {p.Attack})");
        }
    }
}