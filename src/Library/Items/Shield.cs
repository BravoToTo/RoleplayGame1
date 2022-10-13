namespace Library
{
    public class Shield:IItem,IDefense
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