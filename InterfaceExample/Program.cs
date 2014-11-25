using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Hero hero = new Hero();

            hero.IAm();
            do
            {
                cki = Console.ReadKey(true);
                
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    hero.HeroWalkLeft();
                }

                if (cki.Key == ConsoleKey.RightArrow)
                {
                    hero.HeroWalkRight();
                }

            } while (cki.Key != ConsoleKey.Escape);
            Console.ReadLine();
        }
    }
}
