namespace Library
{
    public class Sword:IAttackItem
    {
        public string NameItem{get;}

        public Sword(string name){
            this.NameItem=name;
        }
        public int AttackValue 
        {
            get
            {
                return 20;
            } 
        }
        
    }
}