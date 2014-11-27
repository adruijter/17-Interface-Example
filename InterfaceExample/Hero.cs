using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InterfaceExample
{
    public class Hero
    {
        //Fields
        ConsoleKeyInfo cki, old_cki;
        bool leftPressed = false, rightPressed = false;

        //Properties
        public ConsoleKeyInfo Cki
        {
            get { return this.cki; }
        }
        
        // Constructor
        public Hero() 
        {
            this.IAm();
        }

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

            if (cki.Key == ConsoleKey.S)
            {
                this.HeroStandStill();
            }
        }

        public void IAm()
        {
            Console.WriteLine("Ik ben een Hero");
        }

        private void HeroStandStill()
        {
            Console.WriteLine("Ik ben een Hero en ik sta stil");
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
