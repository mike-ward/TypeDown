using Prism.Windows.Mvvm;
using TypeDown.Services;

namespace TypeDown.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            DisplayText = "This is the main page!";
        }

        public string DisplayText { get; }
    }
}
