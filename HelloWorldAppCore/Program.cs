using System;

namespace HelloWorldAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Users :");

            Console.WriteLine("Please enter your first name :");
            var firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name :");
            var lastname = Console.ReadLine();

            var user = new User(firstname, lastname);
            Console.WriteLine(user.ToString());
            Console.ReadKey();
        }
    }
}
