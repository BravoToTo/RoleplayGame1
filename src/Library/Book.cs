namespace Library;

 
    
public class Book : Spell
{
    public string NameBook;
    public string[] Spells; 

    

    public Book (string NameBook , Spell spells) // heredar la clase Spell
    {
        this.NameBook = NameBook;
        this.Spells = spells;
    }

    public void addSpell (Spell spell)  
    {
        foreach (string phrase in spell)
        {
            Spells.Add(phrase);
        }

    }
    
}