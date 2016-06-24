using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs4Net.Section1._2
{
 

    class ContravariantActionExample
    {
        public static void Merge(Derived a, Derived b)
        {
            //nothing
        }

        Action<Derived, Derived> a1 = Merge;

       // Action<Base, Base> a2 = Merge;

        public static void Merge(Base b1,Base b2) { }

        Action<Base, Base> b = Merge;
    }
}
