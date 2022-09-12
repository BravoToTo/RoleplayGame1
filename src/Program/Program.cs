using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var Wizard = new Race("Wizard", 100, 20, 10);
            var Elf = new Race("Elf", 100, 15, 15);
            var Dwarf = new Race("Dwarf", 150, 30, 30);

            var P1 = new Character("Albert", Wizard);
            var P2 = new Character("Antonio", Dwarf);

            P2.Attack(P1);
        }
    }
}
