namespace Library
{
    public class Sword:IItem
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
        public int DefenseValue 
        {
            get
            {
                return 0;
            } 
        }
    }
}