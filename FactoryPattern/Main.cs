using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("How many tires do tyou want your vehicle to have?");
            string usertires = Console.ReadLine();

            ICallable tires = CycleFactory.GetTires(usertires);
            tires.Build();
        }
    }
}
