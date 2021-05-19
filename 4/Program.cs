using System;

namespace SelectionTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "username";
            string password = "password";

            //user enters their username
            Console.Write("Please enter your username: ");
            string usernameInput = Console.ReadLine();

            //user enters their passwrod
            Console.Write("Please enter your password: ");
            string passwordInput = Console.ReadLine();

            if (usernameInput == username)
            {
                //entered username is correct
                if (passwordInput == password)
                {
                    //entered password is correct
                    Console.WriteLine("You have successfully logged in");
                }
                else
                {
                    //entered password is wrong
                    Console.WriteLine("Login unsuccessful, please try again");
                }
            }
            else
            {
                //entered username is wrong
                Console.WriteLine("Login unsuccessful, please try again");
            }
        }
    }
}
