using AcmeInventory.Enums;
using AcmeInventory.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;

namespace AcmeInventory.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        /// <summary>
        /// Enum to indicate which tab is currently selected
        /// </summary>
        //public enum TabType
        //{
        //    Customer,
        //    Invoice,
        //    Inventory
        //}

        [ObservableProperty]
        private TabType selectedTab;

        /// <summary>
        /// The Customers to display
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<Customer> customers;

        /// <summary>
        /// The Invoices to display
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<Invoice> invoices;

        /// <summary>
        /// The Items to display
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<Item> items;

        /// <summary>
        /// The Invoice Details of the selected Invoice
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<InvoiceDetail> selectedInvoiceDetails;

        [ObservableProperty]
        private bool customersTabIsOpen = false;

        [ObservableProperty]
        private bool inventoryTabIsOpen = false;

        [ObservableProperty]
        private bool invoicesTabIsOpen = false;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainViewModel()
        {

        }

        /// <summary>
        /// The Command that is run when one of the tabs is pressed
        /// </summary>
        /// <param name="buttonPressed">String representing which tab was pressed</param>
        [RelayCommand]
        public void TabButtonPressed(string buttonPressed)
        {
            // Convert the string parameter to an ActiveTab enum
            var tryParse = Enum.TryParse(buttonPressed, out TabType selectedTab);

            if (tryParse)
            {
                SelectedTab = selectedTab;

                // Switch on the parameter enum
                switch (selectedTab)
                {
                    // Customer tab was pressed
                    case TabType.Customer:
                        {
                            CustomersTabIsOpen = true;
                            InvoicesTabIsOpen = false;
                            InventoryTabIsOpen = false;

                            break;
                        }

                    // Invoice tab was pressed
                    case TabType.Invoice:
                        {
                            InvoicesTabIsOpen = true;
                            CustomersTabIsOpen = false;
                            InventoryTabIsOpen = false;

                            break;
                        }

                    // Inventory tab was pressed
                    case TabType.Inventory:
                        {
                            InventoryTabIsOpen = true;
                            CustomersTabIsOpen = false;
                            InvoicesTabIsOpen = false;

                            break;
                        }
                }
                
            }
            else
            {
                throw new Exception();
            }

        }
    }
}