using System;
using Jogo_RPG.src.Entities;

namespace Jogo_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 23, "Knight", 469, 72);
            WizardWhite wizardWhite = new WizardWhite("Jennica", 23, "White wizard", 325, 474);
            Ninja ninja = new Ninja("Wedge", 23, "Ninja", 292, 89);
            WizardBlack wizardBlack = new WizardBlack("Topapa", 23, "Black wizard", 106, 611);
            
           //Console.Write(arus);
            Console.WriteLine(knight.Attack());
            Console.WriteLine(wizardWhite.Attack());
            Console.WriteLine(wizardWhite.Attack(7));
            Console.WriteLine(wizardWhite.Attack(4));
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(ninja.Attack(9));
            Console.WriteLine(ninja.Attack(3));
            Console.WriteLine(wizardBlack.Attack());
            Console.WriteLine(wizardBlack.Attack(7));
            Console.WriteLine(wizardBlack.Attack(4));
            
        }
    }
}
