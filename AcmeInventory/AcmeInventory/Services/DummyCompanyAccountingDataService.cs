using AcmeInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeInventory.Services
{
    public class DummyCompanyAccountingDataService : ICompanyAccountingDataService
    {
        public Task<List<Customer>> GetCustomers()
        {
            throw new NotImplementedException()
        }

        public Task<List<Invoice>> GetInvoices()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvoiceDetail>> GetInvoicesDetail()
        {
            throw new NotImplementedException();
        }

        public Task<List<Item>> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
