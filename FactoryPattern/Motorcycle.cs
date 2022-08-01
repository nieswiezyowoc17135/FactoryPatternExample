using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle : Wehicle
    {
        public override void Creating(string brand)
        {
            Console.WriteLine("Motorcycle is in creating");
        }
    }
}
