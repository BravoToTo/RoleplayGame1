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