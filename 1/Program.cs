using System;

namespace SelectionTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 17)
            {
                Console.WriteLine("Legally adult age");
            }
            else
            {
                Console.WriteLine("Legally not adult age");
            }
        }
    }
}
