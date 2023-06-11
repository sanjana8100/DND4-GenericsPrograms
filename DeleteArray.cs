using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND4_GenericsPrograms
{
    internal class DeleteArray
    {
        public void DeleteMethod(int[] array)
        {
            Console.WriteLine("Type the element that needs to be deleted from the following array: ");
            for (int index = 0; index < array.Length; index++) Console.WriteLine(array[index]);
            int element = Convert.ToInt32(Console.ReadLine());
            int[] newArray = new int[array.Length - 1];
            int newIndex = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] != element)
                {
                    newArray[newIndex] = array[index];
                    newIndex++;
                }
            }
            Console.WriteLine("Array after deleting the element: ");
            for (int index = 0; index < newArray.Length; index++) Console.WriteLine(newArray[index]);
        }

        public void DeleteMethod(double[] array)
        {
            Console.WriteLine("Type the element that needs to be deleted from the following array: ");
            for (int index = 0; index < array.Length; index++) Console.WriteLine(array[index]);
            double element = Convert.ToDouble(Console.ReadLine());
            double[] newArray = new double[array.Length - 1];
            int newIndex = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] != element)
                {
                    newArray[newIndex] = array[index];
                    newIndex++;
                }
            }
            Console.WriteLine("Array after deleting the element: ");
            for (int index = 0; index < newArray.Length; index++) Console.WriteLine(newArray[index]);
        }

        public void DeleteMethod(char[] array)
        {
            Console.WriteLine("Type the element that needs to be deleted from the following array: ");
            for (int index = 0; index < array.Length; index++) Console.WriteLine(array[index]);
            char element = Convert.ToChar(Console.ReadLine());
            char[] newArray = new char[array.Length - 1];
            int newIndex = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] != element)
                {
                    newArray[newIndex] = array[index];
                    newIndex++;
                }
            }
            Console.WriteLine("Array after deleting the element: ");
            for (int index = 0; index < newArray.Length; index++) Console.WriteLine(newArray[index]);
        }
    }
}
