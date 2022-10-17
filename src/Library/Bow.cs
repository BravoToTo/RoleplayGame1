namespace Library
{
    public class Bow:IItem
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
        public int DefenseValue 
        {
            get
            {
                return 0;
            } 
        }
    }
}