using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs4Net.Section1._2
{
    public class Base
    {
    }

    public class Derived : Base
    {
    }

    public class Program
    {
        public static Derived MyMethod(Base b)
        {
            return b as Derived ?? new Derived();
        }



        static void Main()
        {
            Func<Base, Derived> f1 = MyMethod;

            // Covariant return type.
            Func<Base, Base> f2 = f1;
            Base b2 = f2(new Base());

            // Contravariant parameter type.
            Func<Derived, Derived> f3 = f1;
            Derived d3 = f3(new Derived());


            // Covariant return type and contravariant parameter type.
            Func<Derived, Base> f4 = f1;
            Base b4 = f4(new Derived());


        }
    }
}
