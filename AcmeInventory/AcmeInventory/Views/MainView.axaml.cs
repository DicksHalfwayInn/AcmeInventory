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

        public static readonly StyledProperty<TabType> SelectedTabProperty =
            AvaloniaProperty.Register<MainView, TabType>(nameof(ActiveTabDP));

        public TabType ActiveTabDP
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
    }
}