namespace Library
{
    public class Armor:IDefenseItem
    {
        public string NameItem{get;}

        public Armor(string name){
            this.NameItem=name;
        }
        public int DefenseValue
        {
            get
            {
                return 25;
            }
        }
      
    }
}