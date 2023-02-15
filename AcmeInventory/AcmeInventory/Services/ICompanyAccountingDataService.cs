using AcmeInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeInventory.Services
{
    public interface ICompanyAccountingDataService
    {
        Task<List<Customer>> GetCustomers();

        Task<List<Invoice>> GetInvoices();

        Task<List<InvoiceDetail>> GetInvoicesDetail();

        Task<List<Item>> GetItems();
    }
}
