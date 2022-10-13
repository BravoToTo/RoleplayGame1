namespace Library;
public class Spells
{
    public string Name;
    public int Attack;
    public int Defense;
    public Spells(string name, int attack, int defense)
    {
        this.Name = name;
        this.Attack = attack;
        this.Defense = defense;
    }
}