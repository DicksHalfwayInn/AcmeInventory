using AcmeInventory.DataAccess;
using AcmeInventory.Models;
using Avalonia;
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
        public enum ActiveTab
        {
            Customer,
            Invoice,
            Inventory
        }

        // Opacity of a tab that is unselected
        private static double unselectedButtonOpacity = .65;

        // Opacity of a tab that is selected
        private static double selectedButtonOpacity = 1;

        private static CornerRadius unselectedButtonCornerRadius =
            new CornerRadius(5, 5, 5, 5);

        private static CornerRadius selectedButtonCornerRadius = new CornerRadius(0, 0, 0, 0);

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

        /// <summary>
        /// The opacity of the Invoice tab
        /// </summary>
        [ObservableProperty]
        private double invoicesButtonOpacity = unselectedButtonOpacity;

        /// <summary>
        /// The opacity of the Customer tab
        /// </summary>
        [ObservableProperty]
        private double customersButtonOpacity = unselectedButtonOpacity;

        /// <summary>
        /// The opacity of the Inventory tab
        /// </summary>
        [ObservableProperty]
        private double inventoryButtonOpacity = unselectedButtonOpacity;

        [ObservableProperty]
        private bool customersTabIsOpen = false;

        [ObservableProperty]
        private bool inventoryTabIsOpen = false;

        [ObservableProperty]
        private bool invoicesTabIsOpen = false;

        [ObservableProperty]
        private CornerRadius customersTabCornerRadius = unselectedButtonCornerRadius;

        [ObservableProperty]
        private CornerRadius invoicesTabCornerRadius = unselectedButtonCornerRadius;

        [ObservableProperty]
        private CornerRadius inventoryTabCornerRadius = unselectedButtonCornerRadius;

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
            Enum.TryParse(buttonPressed, out ActiveTab tabButton);

            // Switch on the parameter enum
            switch (tabButton)
            {
                // Customer tab was pressed
                case ActiveTab.Customer:
                    {
                        // Highlight the Customer tab and dim the others
                        CustomersButtonOpacity = selectedButtonOpacity;
                        InvoicesButtonOpacity = unselectedButtonOpacity;
                        InventoryButtonOpacity = unselectedButtonOpacity;
                        CustomersTabIsOpen = true;
                        InvoicesTabIsOpen = false;
                        InventoryTabIsOpen = false;
                        CustomersTabCornerRadius = selectedButtonCornerRadius;
                        InvoicesTabCornerRadius = unselectedButtonCornerRadius;
                        InventoryTabCornerRadius = unselectedButtonCornerRadius;

                        break;
                    }

                // Invoice tab was pressed
                case ActiveTab.Invoice:
                    {
                        // Hightlight the Invoice tab and dim the others
                        InvoicesButtonOpacity = selectedButtonOpacity;
                        CustomersButtonOpacity = unselectedButtonOpacity;
                        InventoryButtonOpacity = unselectedButtonOpacity;
                        InvoicesTabIsOpen = true;
                        CustomersTabIsOpen = false;
                        InventoryTabIsOpen = false;
                        InvoicesTabCornerRadius = selectedButtonCornerRadius;
                        CustomersTabCornerRadius = unselectedButtonCornerRadius;
                        InventoryTabCornerRadius = unselectedButtonCornerRadius;
                        break;
                    }

                // Inventory tab was pressed
                case ActiveTab.Inventory:
                    {
                        // Hightlight the Inventory tab and dim the others
                        InventoryButtonOpacity = selectedButtonOpacity;
                        CustomersButtonOpacity = unselectedButtonOpacity;
                        InvoicesButtonOpacity = unselectedButtonOpacity;
                        InventoryTabIsOpen = true;
                        CustomersTabIsOpen = false;
                        InvoicesTabIsOpen = false;
                        InventoryTabCornerRadius = selectedButtonCornerRadius;
                        CustomersTabCornerRadius = unselectedButtonCornerRadius;
                        InvoicesTabCornerRadius = unselectedButtonCornerRadius;
                        break;
                    }
            }
        }
    }
}