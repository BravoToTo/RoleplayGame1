using System.Collections.Generic;

namespace Library
{
    public class SpellsBook:IItem,IAttack,IDefense
    {
        private List<Spell> book = new List<Spell>();
        public string NameItem{get;}

        public SpellsBook(string name){
            this.NameItem=name;
        }

        
        public  Spell  addSpell(string name, int attack, int defense )   
    {
            Spell spell= new Spell(name, attack,defense);
            book.Add(spell);
            return spell;
    }
    
    // Para sacar hechizos
    public void RemoveSpell (Spell spell)
    {
        book.Remove(spell);
    }
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.book)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.book)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
    }
}