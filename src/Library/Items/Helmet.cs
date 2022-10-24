namespace Library
{
    public class Helmet:IDefenseItem
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
        
    }
}