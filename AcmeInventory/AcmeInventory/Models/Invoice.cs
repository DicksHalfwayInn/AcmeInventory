﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeInventory.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }

        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }


        
    }
}
