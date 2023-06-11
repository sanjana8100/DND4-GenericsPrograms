using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND4_GenericsPrograms
{
    internal class MinimumOfThreeUsingGenericClass<T> where T : IComparable<T>
    {
        public T element1, element2, element3;
        public MinimumOfThreeUsingGenericClass(T element1, T element2, T element3)
        {
            this.element1 = element1;
            this.element2 = element2;
            this.element3 = element3;
        }

        public static void FindMinimum(T element1, T element2, T element3)
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

        public void TestMinimum()
        {
            FindMinimum(this.element1, this.element2, this.element3);
        }
    }
}
