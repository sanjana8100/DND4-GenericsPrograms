using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND4_GenericsPrograms
{
    internal class MinimumOfThree
    {
        public void FindMinimum(int number1, int number2, int number3)
        {
            int minimum = number1;
            if(number2 < minimum)
            {
                minimum = number2;
            }
            if(number3 < minimum)
            {
                minimum = number3;
            }
            Console.WriteLine($"The Minimum of the given three numbers {number1}, {number2} and {number3} is: {minimum}");
        }
    }
}
