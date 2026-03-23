using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class PokemonReader
{
    public List<Pokemon> LoadFromCsv(string filePath)
    {
        var list = new List<Pokemon>();
        // Read all lines and skip the header row
        var lines = File.ReadAllLines(filePath).Skip(1);

        foreach (var line in lines)
        {
            var parts = line.Split(',');
            
            // Map the CSV parts to the Pokemon object
            var pokemon = new Pokemon
            {
                Id = int.Parse(parts[0]),
                Name = parts[1],
                Type1 = parts[2],
                Type2 = parts[3],
                Total = int.Parse(parts[4]),
                HP = int.Parse(parts[5]),
                Attack = int.Parse(parts[6]),
                Defense = int.Parse(parts[7]),
                SpAtk = int.Parse(parts[8]),
                SpDef = int.Parse(parts[9]),
                Speed = int.Parse(parts[10]),
                Generation = int.Parse(parts[11]),
                Legendary = bool.Parse(parts[12])
            };
            list.Add(pokemon);
        }
        return list;
    }
}