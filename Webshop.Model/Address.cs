using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.MODEL
{
    public class Address
    {
        public Address()
        {
            CustomerAddresses = new List<CustomerAddress>();
        }
        
        public int AddressId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }
        public List<CustomerAddress> CustomerAddresses { get; set; }
    }
}
