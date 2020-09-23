using System;


namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory ford_car = new FordFactory();
            Client c1 = new Client(ford_car);

            Console.WriteLine("Shape: {0}    Max speed {1} is {2} km/h", c1.ShapeAuto(), c1.ToString(), c1.RunMaxSpeed());

            CarFactory audi_car = AudiFactory.getAudiFactory();
            Client c2 = new Client(audi_car);
            Console.WriteLine("Shape: {0}    Max speed {1} is {2} km/h ", c2.ShapeAuto(), c2.ToString(), c2.RunMaxSpeed());
            
        }
    }
}
