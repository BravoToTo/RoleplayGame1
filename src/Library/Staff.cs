namespace Library
{
    public class Staff:IItem
    {
        public string NameItem{get;}

        public Staff(string name){
            this.NameItem=name;
        }
        public int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 100;
            }
        }
    }
}