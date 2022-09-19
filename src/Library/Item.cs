namespace Library;




public class Item  
/*
Hacer una clase que contenga todos los poderes de los Item

*/
{
    public string NameItem;
    public double AttackItem {get; set;}
    public double DefenseItem {get; set;}

    public  Item (string NameItem , double AttackItem , double DefenseItem)
    {
        this.NameItem = NameItem;
        this.AttackItem = AttackItem;
        this. DefenseItem = DefenseItem;
    }
    /* Hacer un diccionario con todos los item para así llamarlos más fácil????*/
    
    public Item (string NameItem , double AttackItem)
    {
        this.NameItem = NameItem;
        this.AttackItem = AttackItem;
        this.DefenseItem = 0;
    }

    
    
}


