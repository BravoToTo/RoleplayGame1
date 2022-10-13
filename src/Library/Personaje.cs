using System;
using System.Collections;
using System.Collections.Generic;


namespace Library;

public class Character
{
    public string Name;
    private double Init_Health;
    public double Health;
    public Race Type;
    private List<IItem> Inventory= new List<IItem>();

    public Character(string name, Race race)
    {
        this.Name = name;
        this.Type = race;
        this.Health = race.Health;
        this.Init_Health = race.Health;
    }

    public void addItem(IItem item)
    {
        Inventory.Add(item);
    }
    public void removeItem(IItem item)
    {
        Inventory.Remove(item);
    }
    public double getAttack()
    {
        double attack = 0;
        foreach (IItem item in Inventory)
        {
            //attack += item.AttackValue;
        }
        return attack+Type.Attack;
    }
    public double getDefense()
    {
        double defense = 0;
        foreach (IItem item in Inventory)
        {
           // defense += item.DefenseValue;
        }
        return defense+Type.Defense;
    }
    public void Attack(Character character)
    {
        if (character.getDefense() < this.getAttack())
        {
            character.Health -= this.getAttack() - character.getDefense();
            Console.WriteLine("El ataque ha sido exitoso.");
        }
        else
        {
            Console.WriteLine("Ha fallado tu ataque.");
        }
    }
    public void Heal(Character character)
    {
        character.Health = character.Init_Health;
    }


}