using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Unicycle:ICallable
    {
        public void Build()
        {
            Console.WriteLine( "Buiding a Unicycle!");
        }
    }
}
