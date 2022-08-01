using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class Wehicle
    {
        public string Type { get; set; }
        public string Brand { get; set; }

        public abstract void Creating(string brand); 
    }
}
