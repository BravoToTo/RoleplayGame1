using System;
using System.Collections;

namespace Library;

public class Character
{
    public string Name;
    private double Init_Health;
    public double Health;
    public Race Type;
    public ArrayList Inventory = new ArrayList();
    public AttackItem Weapon;
    public DefenseItem Armor;
    public Character(string name, Race race)
    {
        this.Name = name;
        this.Type = race;
        this.Health = race.Health;
        this.Init_Health = race.Health;
    }
    public void equipWeapon(AttackItem item)
    {
        this.Weapon = item;
    }
    public void equipArmor(DefenseItem item)
    {
        this.Armor = item;
    }
    public void addItem(Item item)
    {
        Inventory.Add(item);
    }
    public void removeItem(Item item)
    {
        Inventory.Remove(item);
    }
    public double getAttack()
    {
        double attack = 0;
        foreach (Item item in Inventory)
        {
            //attack += item.AttackItem;
        }
        return attack+Type.Attack;
    }
    public double getDefense()
    {
        double defense = 0;
        foreach (Item item in Inventory)
        {
            //defense += item.DefenseItem;
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