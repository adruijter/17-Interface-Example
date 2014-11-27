using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExample
{
    public class Idle : State
    {
        //Fields
        private Hero hero;

        //Properties


        //Constructor
        public Idle(Hero hero)
        {
            this.hero = hero;
        }

        //Methods
        public void Update()
        {

        }

        public void Info()
        {
            Console.WriteLine("Ik ben een Hero en ik sta stil");
        }
    }
}
