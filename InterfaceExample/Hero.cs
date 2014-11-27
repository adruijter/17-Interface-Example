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
        private State state;

        //Properties
        public ConsoleKeyInfo Cki
        {
            get { return this.cki; }
        }
        
        // Constructor
        public Hero() 
        {
            Console.WriteLine("Ik ben een Hero");
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
                this.state = this.walkLeft;
            }

            if (cki.Key == ConsoleKey.RightArrow)
            {
                this.state = this.walkRight;
            }

            if (cki.Key == ConsoleKey.S)
            {
                this.state = this.idle;
            }
        }

        public void Info()
        {
            this.state.Info();
        }      
    }
}
