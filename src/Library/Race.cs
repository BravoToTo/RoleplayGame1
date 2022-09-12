namespace Library;

public class Race
{
    public string Name;
    public double Health;
    public double Attack;
    public double Defense;
    public Race(string name, double health, double attack, double defense)
    {
        this.Name = name;
        this.Health = health;
        this.Attack = attack;
        this.Defense = defense;
    }
}