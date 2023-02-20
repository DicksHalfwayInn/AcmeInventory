using AcmeInventory.DataAccess;
using AcmeInventory.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;

namespace AcmeInventory.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        public enum ActiveTab
        {
            Customer,
            Invoice,
            Inventory
        }

        private static double unselectedButtonOpacity = .65;

        private static double selectedButtonOpacity = 1;



        [ObservableProperty]
        private ObservableCollection<Customer> customers;

        [ObservableProperty]
        private ObservableCollection<Invoice> invoices;

        [ObservableProperty]
        private ObservableCollection<Item> items;

        [ObservableProperty]
        private ObservableCollection<InvoiceDetail> selectedInvoiceDetails;

        [ObservableProperty]
        private double invoiceButtonOpacity = unselectedButtonOpacity;

        [ObservableProperty]
        private double customerButtonOpacity = unselectedButtonOpacity;

        [ObservableProperty]
        private double inventoryButtonOpacity = unselectedButtonOpacity;

        public MainViewModel()
        {
            


        }

        [RelayCommand]
        public void TabButtonPressed(string buttonPressed)
        {
           Enum.TryParse(buttonPressed, out ActiveTab tabButton);

           switch (tabButton)
            {
                case ActiveTab.Customer:
                    {
                        CustomerButtonOpacity = selectedButtonOpacity;
                        InvoiceButtonOpacity = unselectedButtonOpacity;
                        InventoryButtonOpacity = unselectedButtonOpacity;
                        break;
                    }

                    case ActiveTab.Invoice:
                    {
                        InvoiceButtonOpacity = selectedButtonOpacity;
                        CustomerButtonOpacity = unselectedButtonOpacity;
                        InventoryButtonOpacity = unselectedButtonOpacity;
                        break;
                    }

                case ActiveTab.Inventory:
                    {
                        InventoryButtonOpacity = selectedButtonOpacity;
                        CustomerButtonOpacity = unselectedButtonOpacity;
                        InvoiceButtonOpacity = unselectedButtonOpacity;
                        break;
                    }
              

            }
        }

        
    }
}