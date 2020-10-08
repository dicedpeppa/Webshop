using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.MODEL
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public Order Order { get; set; }
        public PaymentType PaymentType { get; set; }
        public decimal AmountPaid { get; set; }

    }
}
