﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExample
{
    public class Hero
    {
        //Fields

        //Properties
        
        // Constructor
        public Hero()
        {

        }

        //Methods
        public void IAm()
        {
            Console.WriteLine("Ik ben een Hero");
        }

        public void HeroWalkLeft()
        {
            Console.WriteLine("Ik ben een Hero en loop naar links");
        }

        public void HeroWalkRight()
        {
            Console.WriteLine("Ik ben een Hero en loop naar rechts");
        }
    }
}