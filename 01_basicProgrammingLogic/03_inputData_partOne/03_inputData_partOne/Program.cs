using System;

namespace LessonInputData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type something: ");
            string sentence = Console.ReadLine();
            Console.WriteLine($"You typed: {sentence}\n");

            ////////////////////////////////////////////////////////

            Console.WriteLine("Choose 3 colors one at a time:");
            string color1 = Console.ReadLine();
            string color2 = Console.ReadLine();
            string color3 = Console.ReadLine();
            Console.WriteLine($"You chose: {color1}, {color2}, and {color3}\n");

            ////////////////////////////////////////////////////////

            // Split words

            Console.Write("Choose 3 fruits in the same sentence: ");

            string fruitInput = Console.ReadLine();
            string[] fruits = fruitInput.Split(' ');
            string fruit1 = fruits[0];
            string fruit2 = fruits[1];
            string fruit3 = fruits[2];

            Console.WriteLine($"You chose: {fruit1}, {fruit2}, and {fruit3}\n");

            ////////////////////////////////////////////////////////

            // Split words directly

            Console.Write("Choose 3 peripherals in the same sentence: ");

            string[] peripherals = Console.ReadLine().Split(' ');
            string peripheral1 = peripherals[0];
            string peripheral2 = peripherals[1];
            string peripheral3 = peripherals[2];

            Console.WriteLine($"You chose: {peripheral1}, {peripheral2}, and {peripheral3}\n");

            ////////////////////////////////////////////////////////
        }
    }
}