using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.MODEL
{
    public class Customer
    {
        public Customer()
        {
            CustomerAddresses = new List<CustomerAddress>();
        }
        
        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public List<CustomerAddress> CustomerAddresses { get; set; }
    }
}
