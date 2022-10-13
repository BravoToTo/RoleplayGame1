namespace Library
{
    public class Bow:IItem,IAttack
    {
        public string NameItem{get;}

        public Bow(string name){
            this.NameItem=name;
        }
        public int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
    }
}