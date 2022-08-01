using FactoryPattern;
using System;
class Program
{
    static void Main(string[] args)
    {
        var wehicleFactory = new WehicleFactory();
        var newWehicle = wehicleFactory.CreateWehicle(WehicleType.Car);
        newWehicle.Creating("Audi");
    }
}