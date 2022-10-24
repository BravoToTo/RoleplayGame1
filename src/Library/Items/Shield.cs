namespace Library
{
    public class Shield:IDefenseItem
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
       
        
    }
}