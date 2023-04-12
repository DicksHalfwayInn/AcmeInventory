using Avalonia;
using Avalonia.Controls;
using static AcmeInventory.ViewModels.MainViewModel;
using System;
using AcmeInventory.Enums;

namespace AcmeInventory.Views
{
    public partial class MainView : UserControl
    {
        // Opacity of a tab that is unselected
        private static double unselectedButtonOpacity = .65;

        // Opacity of a tab that is selected
        private static double selectedButtonOpacity = 1;

        // Corner radius of a tab that is unselected
        private static CornerRadius unselectedButtonCornerRadius =
            new CornerRadius(5, 5, 5, 5);

        // Corner radius of a tab that is selected
        private static CornerRadius selectedButtonCornerRadius = 
            new CornerRadius(0, 0, 0, 0);

        public MainView()
        {
            InitializeComponent();

            // TODO:  Why is this defaulting to customer on initial run
            this.GetObservable(SelectedTabProperty).Subscribe(x => SetTabButtonStyles(x));


        }

        

        /// <summary>
        /// Direct Property that is bound to the SelectedTab property in MainViewModel
        /// </summary>
        public static readonly StyledProperty<TabType> SelectedTabProperty =
            AvaloniaProperty.Register<MainView, TabType>(nameof(SelectedTab));

        
        public TabType SelectedTab
        {
            get
            {
                return GetValue(SelectedTabProperty);
            }

            set
            {
                SetValue(SelectedTabProperty, value);
            }
        }

        private void SetTabButtonStyles(TabType selectedTab)
        {
            // Customers Tab
            if (selectedTab == TabType.Customer)
            {
                CustomersTab.Opacity = selectedButtonOpacity;
                CustomersTab.CornerRadius = selectedButtonCornerRadius;

                InvoicesTab.Opacity = unselectedButtonOpacity;
                InvoicesTab.CornerRadius = unselectedButtonCornerRadius;

                InventoryTab.Opacity = unselectedButtonOpacity;
                InventoryTab.CornerRadius = unselectedButtonCornerRadius;
            }

            // Invoices Tab
            if (selectedTab == TabType.Invoice)
            {
                CustomersTab.Opacity = unselectedButtonOpacity;
                CustomersTab.CornerRadius = unselectedButtonCornerRadius;

                InvoicesTab.Opacity = selectedButtonOpacity;
                InvoicesTab.CornerRadius = selectedButtonCornerRadius;

                InventoryTab.Opacity = unselectedButtonOpacity;
                InventoryTab.CornerRadius = unselectedButtonCornerRadius;
            }

            // Inventory Tab
            if (selectedTab == TabType.Inventory)
            {
                CustomersTab.Opacity = unselectedButtonOpacity;
                CustomersTab.CornerRadius = unselectedButtonCornerRadius;

                InvoicesTab.Opacity = unselectedButtonOpacity;
                InvoicesTab.CornerRadius = unselectedButtonCornerRadius;

                InventoryTab.Opacity = selectedButtonOpacity;
                InventoryTab.CornerRadius = selectedButtonCornerRadius;
            }
        }

        private void OnSelectedTabChanged(TabType newValue)
        {
            SetTabButtonStyles(newValue);
        }
    }
}
