using System;
using System.Collections.Generic;

using Library;
public class Knight:ICharacter{

    private int health;
    private List<IItem> Items= new List<IItem>();
    public Knight(string name)
    {
        string Name=name;
    }
    public string Name
    {   
        get{
            return this.Name;
        }
    }
     public int InitialHealth
    {
        get{
            return 100;
        }
    }
    public int Health
    {   
        get{
            return this.Health;
        }
        set{
            this.Health=value;
        }
    }
    public int AttackValue
    {   
        get
        {
            int attack=0;
            foreach(IAttackItem item in Items)
            {
                attack+=item.AttackValue;
            }
            return attack;
        }
    }
    public int DefenseValue
    {   
        get
        {
            foreach(IDefenseItem item in Items)
            {
                this.DefenseValue+=item.DefenseValue;
            }
            return this.DefenseValue;
        }
        set{this.DefenseValue=value;}
    }
    public void AddItem(IItem item)
    {
        this.Items.Add(item);
    }
    public void RemoveItem(IItem item)
    {
        this.Items.Remove(item);

    }
    public void Cure(){
        this.Health=this.InitialHealth;
    }
    public void ReceiveAttack(ICharacter attacker){
        if(attacker.AttackValue> this.DefenseValue)
        {
            this.Health-= attacker.AttackValue-this.DefenseValue;
            Console.WriteLine($"El ataque ha vencido las defensas de {this.Name}.\nVida restante: {this.Health}");
        }
        else{
            this.DefenseValue-=attacker.AttackValue;
            Console.WriteLine($"Los escudos de {this.Name} resistieron el ataque.\nEscudo restante: {this.DefenseValue}");

        }
    }
}