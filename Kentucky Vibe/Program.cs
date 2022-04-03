// See https://aka.ms/new-console-template for more information
 using System;
using System.Text.RegularExpressions;

namespace KentuckyVibe
{

    class Program
    {
        static void Main()
        {
            WelcomeCustomer();
            var registerResponse = GatherUserInput();
            List<Customer> customers = new List<Customer>();

            while (registerResponse == "y")

            {
                //This code runs until the while condition is false.
                var customer = new Customer();
                Console.WriteLine("Please put in your firstname");
                customer.FirstName = Console.ReadLine();

                Console.WriteLine("Please put in your lastname");
                customer.LastName = Console.ReadLine();
                customers.Add(customer);
                registerResponse = GatherUserInput();
            }
            Console.WriteLine("Here is the list of customers");
            customers.ForEach(customer => { Console.WriteLine(customer.FullName); });

        }

        private static void WelcomeCustomer()
        {
            Console.WriteLine("Hello,Welcome to Kentucky Vibe");
        }

        public static bool ValidateUserInput(string input) {
            string paturn = @"^[YNyn\s]{1}$";
            Regex rg=new Regex(@paturn);
            return rg.IsMatch(input);
        
        
        }
        public static string GatherUserInput () {
            Console.WriteLine("DO you want to Register (Y/N)");
            var registerResponse = Console.ReadLine().ToLower();
            var isInputValid = ValidateUserInput(registerResponse);
            while (isInputValid == false)
            {
                Console.WriteLine("Your input is not valid please enter a y or a n");
                registerResponse = Console.ReadLine().ToLower();
                isInputValid = ValidateUserInput(registerResponse);

            }


            return registerResponse;
            }
    }

}