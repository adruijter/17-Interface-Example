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
            //Fields
            Hero hero = new Hero();

            hero.IAm();
            do
            {
                hero.Update();
            } while (hero.Cki.Key != ConsoleKey.Escape);
        }
    }
}
