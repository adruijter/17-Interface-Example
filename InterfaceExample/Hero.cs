using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExample
{
    public class Hero
    {
        //Fields
        ConsoleKeyInfo cki;

        //Properties
        public ConsoleKeyInfo Cki
        {
            get { return this.cki; }
        }
        
        // Constructor
        public Hero() { }

        //Methods
        public void Update()
        {
            cki = Console.ReadKey(true);

            if (cki.Key == ConsoleKey.LeftArrow)
            {
                this.HeroWalkLeft();
            }
            if (cki.Key == ConsoleKey.RightArrow)
            {
                this.HeroWalkRight();
            }
        }

        public void IAm()
        {
            Console.WriteLine("Ik ben een Hero");
        }

        private void HeroWalkLeft()
        {
            Console.WriteLine("Ik ben een Hero en loop naar links");
        }

        private void HeroWalkRight()
        {
            Console.WriteLine("Ik ben een Hero en loop naar rechts");
        }


    }
}
