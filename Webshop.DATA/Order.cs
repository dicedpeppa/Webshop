using System;
using System.Collections.Generic;
using System.Text;
using Webshop.DATA;

namespace Webshop.MODEL
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StatusDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
