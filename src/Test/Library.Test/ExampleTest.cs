using NUnit.Framework;
using Library;
namespace Library.Tests;

[TestFixture]
    public class ExampleTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void AttackingOk()
        {
            string expected= "2022-10-12";
            string date="12/10/2022";
            

            ICharacter atacante=new Archer("Tilingo");
            ICharacter atacado= new Dwarf("Machinbu");

            IItem item1= new Axe("Hacha");
            IItem item2= new Staff("Baston");
            IItem item3= new Sword("Espada");
            IItem item4= new Shield("Escudo");
            IItem item5= new Bow("Arco");

            atacante.AddItem(item1);
            atacante.AddItem(item3);
            atacante.AddItem(item5);
            atacado.AddItem(item2);
            atacado.AddItem(item4);
        
         


        }
}