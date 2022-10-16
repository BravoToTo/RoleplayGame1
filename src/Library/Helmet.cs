namespace Library
{
    public class Helmet:IItem
    {
        public string NameItem{get;}

        public Helmet(string name){
            this.NameItem=name;
        }
        public int DefenseValue
        {
            get
            {
                return 18;
            }
        }
        public int AttackValue 
        {
            get
            {
                return 0;
            } 
        }
    }
}