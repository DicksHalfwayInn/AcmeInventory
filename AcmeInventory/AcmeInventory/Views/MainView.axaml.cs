using Avalonia;
using Avalonia.Controls;
using static AcmeInventory.ViewModels.MainViewModel;

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
        private static CornerRadius selectedButtonCornerRadius = new CornerRadius(0, 0, 0, 0);

        public MainView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Direct Property that is bound to the SelectedTab property in MainViewModel
        /// </summary>
        public static readonly StyledProperty<TabType> SelectedTabProperty =
            AvaloniaProperty.Register<MainView, TabType>(nameof(SelectedTab),
                defaultBindingMode: Avalonia.Data.BindingMode.TwoWay);

        /// <summary>
        /// Somewhere in here I need to change the selected opacity and corner radius
        /// for the selected tab and change them for the other tabs to be set to
        /// opacity and corner radius for an unselected tab
        /// </summary>
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
