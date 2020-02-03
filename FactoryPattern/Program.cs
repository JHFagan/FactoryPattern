using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires do tyou want your vehicle to have?");
            string usertires = Console.ReadLine();

            ICallable tires = CarFactory.GetTires(usertires);
            tires.Build();
        }
    }
}
