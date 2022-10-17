namespace Library;



public interface Item
{
    
}
public class AttackItem : Item 
{
    public string ItemName;
    public double ItemAttack;
    public double ItemDefense;
}

public class DefenseItem : Item 
{
    public string ItemName;
    public double ItemDefense;
}
public class MagicItem : Item 
{
    public string ItemName;
    public double ItemAttack;
    public double ItemDefense;
}