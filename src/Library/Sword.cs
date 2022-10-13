namespace Library
{
    public class Sword:IItem,IAttack
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