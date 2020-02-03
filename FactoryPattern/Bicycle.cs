using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Bicycle: ICallable
    {
        public void Build()
        {
            Console.WriteLine("Buiding a Bicycle!");
        }
    }
}
