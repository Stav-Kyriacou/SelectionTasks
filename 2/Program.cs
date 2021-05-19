using System;

namespace SelectionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your gender: ");
            string gender = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 17)
            {
                Console.WriteLine("{0} is an adult", gender);
            }
            else
            {
                Console.WriteLine("{0} is not an adult", gender);
            }
        }
    }
}
