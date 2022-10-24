using System;
using System.Collections;
using System.Collections.Generic;


namespace Library;

public interface ICharacter
{
    public string Name{get;}
    //private double Init_Health{get;}
    public int InitialHealth{get;}
    public int Health{get;set;}
    int AttackValue{get;}
    int DefenseValue{get;}
    void AddItem(IItem item);
    void RemoveItem(IItem item);
    void Cure();
    void ReceiveAttack(ICharacter attacker);
}
    //private List<IItem> Inventory= new List<IItem>();