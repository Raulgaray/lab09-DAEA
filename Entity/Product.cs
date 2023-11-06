using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }

        public string Active { get; set; }
    }
}
