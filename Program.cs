namespace DND4_GenericsPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 10, 20, 30, 40, 50 };
            double[] doubleArray = { -5.22, -3.54, 0.88, 2.97, 1.45 };
            char[] charArray = { 'A', 'b', 'C', 'd', 'E' };

            //Delete element in array for int, double and char
            DeleteArray deleteArray = new DeleteArray();
            deleteArray.DeleteMethod(intArray);
            deleteArray.DeleteMethod(doubleArray);
            deleteArray.DeleteMethod(charArray);

        }
    }
}