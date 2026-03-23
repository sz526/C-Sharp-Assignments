public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; // or public required string Name { get; set; } C#11
    public string Type1 { get; set; } = string.Empty;// Nullable Reference Types
    public string? Type2 { get; set; } // it can be null
    public int Total { get; set; }
    public int HP { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int SpAtk { get; set; }
    public int SpDef { get; set; }
    public int Speed { get; set; }
    public int Generation { get; set; }
    public bool Legendary { get; set; }
}