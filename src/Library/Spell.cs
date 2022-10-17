namespace Library
{
    public class Spell
    {
        public string NameItem{get;}
        public int AttackValue{get;}
        public int DefenseValue{get;}

        public Spell(string name,int attack, int defense){
            this.NameItem=name;
            this.AttackValue=attack;
            this.DefenseValue=defense;
        }
        
        
    }
}