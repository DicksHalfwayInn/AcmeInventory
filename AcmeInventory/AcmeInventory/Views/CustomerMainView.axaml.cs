using AcmeInventory.ViewModels;
using Avalonia.Controls;

namespace AcmeInventory.Views
{
    public partial class CustomerMainView : UserControl
    {
        public CustomerMainView()
        {
            InitializeComponent();

            DataContext = new CustomerMainViewModel();

       
        }
    }
}
