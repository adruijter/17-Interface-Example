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
        private ConsoleKeyInfo cki;
        private WalkRight walkRight;
        private WalkLeft walkLeft;
        private Idle idle;

        //Properties
        public ConsoleKeyInfo Cki
        {
            get { return this.cki; }
        }
        
        // Constructor
        public Hero() 
        {
            this.IAm();
            this.walkRight = new WalkRight(this);
            this.walkLeft = new WalkLeft(this);
            this.idle = new Idle(this);
        }

        //Methods
        public void Update()
        {
            cki = Console.ReadKey(true);

            if (cki.Key == ConsoleKey.LeftArrow)
            {
                this.walkLeft.Info();
            }

            if (cki.Key == ConsoleKey.RightArrow)
            {
                this.walkRight.Info();
            }

            if (cki.Key == ConsoleKey.S)
            {
                this.idle.Info();
            }
        }

        public void Info()
        {

        }

        public void IAm()
        {
            Console.WriteLine("Ik ben een Hero");
        }

       
    }
}
