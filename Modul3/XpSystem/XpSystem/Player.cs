namespace XpSystem;

public class Player
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Xp { get; private set; }

    public Player(string name)
    {
        Name = name;
        Level = 1;
        Xp = 0;
    }

}