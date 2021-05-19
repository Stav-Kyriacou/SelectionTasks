using System;

namespace SelectionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            if (sum > 10)
            {
                Console.WriteLine("The sum of the two numbers is greater than 10");
            }
            else if (sum < 10)
            {
                Console.WriteLine("THe sum of the two numbers is less than 10");
            }
            else
            {
                Console.WriteLine("The sum of the two numbers is equal to 10");
            }
        }
    }
}
