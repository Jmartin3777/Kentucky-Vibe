using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentuckyVibe
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public bool Validate() { return true; }
        public bool Retrieve() { return true; }
        public bool Save() { return true; }

        
    }
    public class Product
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
    public bool Validate() { return true; }
    public bool Retrieve() { return true; }
    public bool Save() { return true; }
}
    
}