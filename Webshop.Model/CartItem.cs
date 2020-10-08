using System;
using System.Collections.Generic;
using System.Text;
using Webshop.DATA;

namespace Webshop.MODEL
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

    }
}
