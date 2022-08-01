using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class WehicleFactory
    {
        public Wehicle CreateWehicle(WehicleType type)
        {
            if (type == WehicleType.Car)
            {
                return new Car();
            } else if (type == WehicleType.Scooter)
            {
                return new Scooter();
            } else if (type == WehicleType.Motorcycle)
            {
                return new Motorcycle();
            } else
            {
                throw new Exception("chujowe dane wariacie");
            }
            
        }
    }
}
