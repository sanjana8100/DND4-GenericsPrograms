using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND4_GenericsPrograms
{
    internal class MinimumOfThreeUsingGenerics
    {
        public void FindMinimum<T>(T element1, T element2, T element3) where T : IComparable<T>
        {
            T minimum = element1;
            if (element2.CompareTo(minimum) < 0)
            {
                minimum = element2;
            }
            if (element3.CompareTo(minimum) < 0)
            {
                minimum = element3;
            }
            Console.WriteLine($"The Minimum of the given three elements {element1}, {element2} and {element3} is: {minimum}");
        }
    }
}
