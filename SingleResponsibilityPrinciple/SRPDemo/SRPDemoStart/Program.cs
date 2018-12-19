using System;

namespace SRPDemoStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application!");
            Person user = new Person();
            
            Console.WriteLine("What is your first name?");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            user.LastName = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("First Name is not a valid name.");
                Console.ReadLine();
                return;
            }
            if(string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("Last Name is not a valid name.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Your username is  {user.FirstName.Substring(0,1)}{user.LastName}");

            Console.Read();
        }
    }
}
