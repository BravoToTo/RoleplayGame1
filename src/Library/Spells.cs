namespace Library;

public class Spells
{
    public string Race;
    public double StartAttack;
    public double StartDefense;
    public double HealthMulti;
    public Spells(string race, double startAttack, double startDefense, double healthMulti)
    {
        this.Race = race;
        this.StartAttack = startAttack;
        this.StartDefense = startDefense;
        this.HealthMulti = healthMulti;
    }
}