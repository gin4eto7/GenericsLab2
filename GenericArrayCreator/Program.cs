using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] array = ArrayCreator.Create(10, "Pesho");
            Console.WriteLine(String.Join(",", array));
            int[] integers = ArrayCreator.Create(10, 33);
            Console.WriteLine(String.Join(",", integers));
        }
    }
}
