using TypeDown.ViewModels;

namespace TypeDown.Views
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPageViewModel ConcreteDataContext => DataContext as MainPageViewModel;
    }
}
