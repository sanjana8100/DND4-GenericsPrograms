namespace DND4_GenericsPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 10, 20, 30, 40, 50 };
            double[] doubleArray = { -5.22, -3.54, 0.88, 2.97, 1.45 };
            char[] charArray = { 'A', 'b', 'C', 'd', 'E' };

            //P1- Delete element in array for int, double and char
            DeleteArray deleteArray = new DeleteArray();
            deleteArray.DeleteMethod(intArray);
            deleteArray.DeleteMethod(doubleArray);
            deleteArray.DeleteMethod(charArray);

            //P2- Delete element in array for int, double and char using Generics
            DeleteArrayUsingGenerics deleteArrayUsingGenerics = new DeleteArrayUsingGenerics();
            intArray = deleteArrayUsingGenerics.DeleteMethod(intArray, 20);
            doubleArray = deleteArrayUsingGenerics.DeleteMethod(doubleArray, 0.88);
            charArray = deleteArrayUsingGenerics.DeleteMethod(charArray, 'b');

            //P3- Delete element in array for int, double and char using Generic Class
            DeleteArrayUsingGenericClass<int> deleteArrayUsingGenericClass1 = new DeleteArrayUsingGenericClass<int>();
            intArray = deleteArrayUsingGenericClass1.DeleteMethod(intArray, 30);

            DeleteArrayUsingGenericClass<double> deleteArrayUsingGenericClass2 = new DeleteArrayUsingGenericClass<double>();
            doubleArray = deleteArrayUsingGenerics.DeleteMethod(doubleArray, 1.45);

            DeleteArrayUsingGenericClass<char> deleteArrayUsingGenericClass3 = new DeleteArrayUsingGenericClass<char>();
            charArray = deleteArrayUsingGenerics.DeleteMethod(charArray, 'd');

            //P4- Given three integers, find the Minimum
            MinimumOfThree minimumOfThree = new MinimumOfThree();
            minimumOfThree.FindMinimum(20, 60, 10);

            //P5- Given three floats, find the Minimum
            minimumOfThree.FindMinimum(9.54, 5.32, 6.48);

            //P6- Given three strings, find the Minimum
            minimumOfThree.FindMinimum("apple", "orange", "mango");
        }
    }
}