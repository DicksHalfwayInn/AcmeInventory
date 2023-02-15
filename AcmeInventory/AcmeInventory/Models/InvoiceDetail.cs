using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeInventory.Models
{
    public class InvoiceDetail
    {
        public int DetailId { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }


    }
}
