using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.MODEL
{
    public class CustomerAddress
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public Customer Customer { get; set; }
        public Address Address { get; set; }
    }
}
