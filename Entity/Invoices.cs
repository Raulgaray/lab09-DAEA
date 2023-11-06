using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int CustomerId{ get; set; }
        public string Date { get; set; }
        public double Total { get; set; }

        public bool Active { get; set; }

    }
}
