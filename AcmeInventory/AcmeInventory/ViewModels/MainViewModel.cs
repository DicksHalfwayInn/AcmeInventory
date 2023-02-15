using AcmeInventory.DataAccess;

namespace AcmeInventory.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public string Greeting => "Hi Stuartzxcvzxcv";

        public MainViewModel()
        {
            var Data = new CompanyAccountingContext();


        }
    }
}