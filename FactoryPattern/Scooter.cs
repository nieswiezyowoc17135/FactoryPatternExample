﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Scooter : Wehicle
    {
        public override void Creating(string brand)
        {
            Console.WriteLine("Scooter is in creating");
        }
    }
}
