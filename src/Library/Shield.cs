namespace Library
{
    public class Shield:IItem
    {
        public string NameItem{get;}

        public Shield(string name){
            this.NameItem=name;
        }
        public int DefenseValue
        {
            get
            {
                return 14;
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