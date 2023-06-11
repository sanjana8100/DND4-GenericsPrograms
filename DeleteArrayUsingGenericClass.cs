using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND4_GenericsPrograms
{
    internal class DeleteArrayUsingGenericClass <T>
    {
        public T[] DeleteMethod(T[] array, T element)
        {
            T[] newArray = new T[array.Length - 1];
            int newIndex = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (!array[index].Equals(element))
                {
                    newArray[newIndex] = array[index];
                    newIndex++;
                }
            }
            Console.WriteLine("Array after deleting the element " + element + ": ");
            for (int index = 0; index < newArray.Length; index++) Console.WriteLine(newArray[index]);
            return newArray;
        }
    }
}
