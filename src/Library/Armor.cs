namespace Library
{
    public class Armor:IItem
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
        public int AttackValue 
        {
            get
            {
                return 0;
            } 
        }
    }
}