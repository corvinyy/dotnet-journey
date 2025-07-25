using System;
using System.Globalization; //IMPORTANT

namespace InputDataExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert int to string, since Console.ReadLine only reads strings

            Console.Write("Choose an integer number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"You chose {number1}\n");

            ////////////////////////////////////////////////////

            Console.Write("Enter a character: ");
            char character = char.Parse(Console.ReadLine());

            Console.WriteLine($"Character chosen: {character}\n");

            ////////////////////////////////////////////////////

            Console.Write("Choose a double number: ");

            // If you use a period, you need CultureInfo.InvariantCulture; otherwise, use a comma
            double number2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Double chosen: {number2.ToString(CultureInfo.InvariantCulture)}\n");

            ////////////////////////////////////////////////////

            Console.Write("Enter name, gender, age and height: \n");

            string[] data = Console.ReadLine().Split(' ');
            string name = data[0];
            char gender = char.Parse(data[1]);
            int age = int.Parse(data[2]);
            double height = double.Parse(data[3], CultureInfo.InvariantCulture);

            Console.WriteLine("\n>PROFILE<");
            Console.WriteLine($"Name: {name}\nGender: {gender}\nAge: {age} years\nHeight: {height.ToString("F2", CultureInfo.InvariantCulture)}");

            ////////////////////////////////////////////////////
        }
    }
}