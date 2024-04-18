using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D_Domain.Entities
{
    public class Sale
    {
        public int SaleId { get; set; }
        public decimal TotalPay { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal Taxes { get; set; } 
        public DateTime Date { get; set; }

        public IList<SaleProduct> SalesProducts { get; set; }
    }
}