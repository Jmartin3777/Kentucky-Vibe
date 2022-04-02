// See https://aka.ms/new-console-template for more information
 using System;
using System.Text.RegularExpressions;

namespace KentuckyVibe
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello,Welcome to Kentucky Vibe");
            Console.WriteLine("DO you want to Register (Y/N)");
            var registerResponse = Console.ReadLine().ToLower();
            List<Customer> customers = new List<Customer>();
            var isInputValid = ValidateUserInput(registerResponse);
            while (isInputValid == false)
            {
             Console.WriteLine("Your input is not valid please enter a y or a n");
             registerResponse = Console.ReadLine().ToLower();
             isInputValid = ValidateUserInput(registerResponse);

            }

            while (registerResponse == "y")

            {
                //This code runs until the while condition is false.
                var customer = new Customer();
                Console.WriteLine("Please put in your firstname");
                customer.FirstName = Console.ReadLine();

                Console.WriteLine("Please put in your lastname");
                customer.LastName = Console.ReadLine();
                customers.Add(customer);
                Console.WriteLine("DO you want to Register (Y/N)");
                registerResponse = Console.ReadLine().ToLower();
                isInputValid = ValidateUserInput(registerResponse);

                while (isInputValid == false)
                {
                    Console.WriteLine("Your input is not valid please enter a y or a n");
                    registerResponse = Console.ReadLine().ToLower();
                    isInputValid = ValidateUserInput(registerResponse);

                }

            }
            Console.WriteLine("Here is the list of customers");
            customers.ForEach(customer => { Console.WriteLine(customer.FullName); });

        }
        public static bool ValidateUserInput(string input) {
            string paturn = @"^[YNyn\s]{1}$";
            Regex rg=new Regex(@paturn);
            return rg.IsMatch(input);
        
        
        }
    }

}