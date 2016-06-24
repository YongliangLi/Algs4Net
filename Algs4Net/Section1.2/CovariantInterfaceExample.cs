using System;
using System.Collections.Generic;

class Base
{
    /* 
    Starting with the.NET Framework 4, several generic interfaces have covariant type parameters; for example: 
    IEnumerable<T>, IEnumerator<T>, IQueryable<T>, and IGrouping<TKey, TElement>.
    All the type parameters of these interfaces are covariant, so the type parameters are used only for the return types of the members.  
    */
    public static void PrintBases(IEnumerable<Base> bases)
    {
        foreach (Base b in bases)
        {
            Console.WriteLine(b);
        }
    }
}

class Derived : Base
{
    public static void Main()
    {
        List<Derived> dlist = new List<Derived>();

        Derived.PrintBases(dlist);
        IEnumerable<Base> bIEnum = dlist;
    }
}