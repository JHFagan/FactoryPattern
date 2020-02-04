using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    static class CycleFactory
    {


        public static ICallable GetTires(string usertires)
        {
            switch (Convert.ToInt32(usertires))
            {

                case 1:
                    return new Unicycle();
                case 2:
                    return new Bicycle();
                case 3:
                    return new Tricycle();
                default:
                    return new Bicycle();
            }
        }
    }
}
