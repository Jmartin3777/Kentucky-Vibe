// See https://aka.ms/new-console-template for more information
 using System;


namespace KentuckyVibe
{

    class Program
    {
        static void Main ()
        {
            Console.WriteLine("Hello,Welcome to Kentucky Vibe");
            Console.WriteLine("DO you want to Register (Y/N)");
            var registerResponse = Console.ReadLine().ToLower();

            while (registerResponse == "y")

            {
                //This code runs until the while condition is false.
                List<Customer> customers = new List<Customer>();
                var customer = new Customer();
                Console.WriteLine("Please put in your firstname");
                customer.FirstName = Console.ReadLine();

                Console.WriteLine("Please put in your lastname");
                customer.LastName = Console.ReadLine();
                customers.Add(customer);
                Console.WriteLine("Here is the list of customers");
                customers.ForEach(customer => { Console.WriteLine(customer.FullName); });
                Console.WriteLine("DO you want to Register (Y/N)");
                registerResponse = Console.ReadLine().ToLower();

            }

        }
    }
}