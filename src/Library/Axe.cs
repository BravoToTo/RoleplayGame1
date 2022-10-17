namespace Library
{
    public class Axe:IItem
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
        public int DefenseValue 
        {
            get
            {
                return 0;
            } 
        }
    }
}