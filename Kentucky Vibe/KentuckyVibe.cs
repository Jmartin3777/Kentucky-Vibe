using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentuckyVibe
{
    public class Customer
    {
        public string CustomerID { get; set;}
        public string EmailAddress { get; set;}
        public string First name { get; set;}
        public String Last name { get; set;}
        public bool Validate() { }
        public bool Retrieve() { }
        public bool Save() { }
    }
    public class Product
{
    public string Product { get; set; }
    public string Product Name { get; set; }
    public string Poduct Price { get; set; }
    public bool Validate() { }
    public bool Retrieve() { }
    public bool Save() { }
}
    public class Order 
{   
    public string Customer { get; set; }
    public string Product name { get; set; }
    public string Product Price { get; set; }
    public bool Validate() { }
    public bool Retrieve() { }
    public bool Save() { }

}

    public class Order Iteam
{
    public string Order Iteam { get; set; }
    public string Order Date { get; set; }
    public string Order Time{ get; set; }
    public String Customer name { get; set; }
    public bool Validate() { }
    public bool Retrieve () { }
    public bool Save () { }
}
}