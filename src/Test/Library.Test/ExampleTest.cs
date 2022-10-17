using NUnit.Framework;
using Library;
namespace Library.Tests;

//namespace Test.Library
//{
    public class ExampleTest
    {
        [Test]
        public void AttackingOk()
        {
            var race1 = new Race("Wizard", 100, 20, 10);
            Character personaje1= new Character("Jorge Rial",race1);
            
            var race2 = new Race("Dwarf", 150, 50, 30);
            Character personaje2= new Character("Nisman",race2);
            personaje2.Attack(personaje1);
            double expected=100-(50-10);
            
            Assert.AreEqual(expected,personaje1.Health);
        }
        [Test]
        public void AttackingNotOk()
        {
            var race1 = new Race("Wizard", 100, 20, 220);
            Character personaje1= new Character("Jorge Rial",race1);
            
            var race2 = new Race("Dwarf", 150, 50, 30);
            Character personaje2= new Character("Nisman",race2);
            personaje2.Attack(personaje1);
            double expected=100;
            
            Assert.AreEqual(expected,personaje1.Health);
        }
        [Test]
        public void AttackingTo()
        {
            var race3 = new Race("Morfeo", 300, 60, 40);
            Character personaje3= new Character("tv",race3);
            
            var race4 = new Race("Costelo", 220, 80, 20);
            Character personaje4= new Character("radio",race4);
            personaje4.Attack(personaje3);
            double expected=300-(80-40);
            
            Assert.AreEqual(expected,personaje3.Health);
        }

        /*[Test]
        public void CorrectRace()
        {
            string expected="";
            var race1 = new Race("Reward", 100, 20, 10);
            Assert.AreEqual(expected,race1);//Hay que agregar un metodo en la clase Race,
                                            //para verificar si la raza es valida.
        }*/
    }
//}