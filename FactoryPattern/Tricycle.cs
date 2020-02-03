using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Tricycle:ICallable
    {
        public void Build()
        {
            Console.WriteLine("Buiding a Tricycle!");
        }
    }
}
