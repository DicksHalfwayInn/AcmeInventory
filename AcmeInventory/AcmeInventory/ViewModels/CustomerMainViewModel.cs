using AcmeInventory.DataAccess;
using AcmeInventory.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeInventory.ViewModels
{
    public partial class CustomerMainViewModel : ObservableObject
    {
        private CompanyAccountingContext db = new();

        [ObservableProperty]private bool addCustomerIsOpen = false;

        [ObservableProperty]private ObservableCollection<Customer> customers= new ObservableCollection<Customer>();

        public CustomerMainViewModel()
        {
            customers = GetCustomersFromDatabase();
        }

        private ObservableCollection<Customer> GetCustomersFromDatabase()
        {
        //Customers = db.Customers;

        //return Customers;

        return new();
        }
    }
}
