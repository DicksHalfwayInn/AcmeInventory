﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeInventory.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Identifier { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        public Item(int id, string identifier, string description, decimal price, int quantity)
        {
            Id = id;
            Identifier = identifier;
            Description = description;
            Price = price;
            Quantity = quantity;

        }


    }
}
