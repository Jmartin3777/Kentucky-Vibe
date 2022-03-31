// See https://aka.ms/new-console-template for more information
 using System;


namespace KentuckyVibe
{

    class Program
    {
        static void Main ()
        {
            Console.WriteLine("Hello,Welcome to Kentucky Vibe");
           
            List<Customer> customers = new List<Customer> ();
            var customer = new Customer ();
            Console.WriteLine("Please put in your firstname");
            customer.FirstName = Console.ReadLine ();

            Console.WriteLine("Please put in your lastname");
            customer.LastName = Console.ReadLine ();
            customers.Add (customer);
            Console.WriteLine("Here is the list of customers");
            customers.ForEach (customer => { Console.WriteLine(customer.FullName); });
        }
    }
}