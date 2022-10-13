namespace Library
{
    public class Axe:IItem,IAttack
    {
        public string NameItem{get;}

        public Axe(string name){
            this.NameItem=name;
        }
        public int AttackValue 
        {
            get
            {
                return 25;
            } 
        }
    }
}