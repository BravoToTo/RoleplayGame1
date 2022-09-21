using System;
using System.Collections;

namespace Library;


 
    
public class Book 
{
    public string NameBook;
    public ArrayList Spells = new ArrayList(); 

    

    public Book (string NameBook) 
    {
        this.NameBook = NameBook;
    }

// Metodo para agregar hechizos.
    public void addSpell (Spells spell)   
    {
            
            Spells.Add(spell);

    }
    
    // Para sacar hechizos
    public void RemoveSpell (Spells spell)
    {
        Spells.Remove(spell);
    }

}