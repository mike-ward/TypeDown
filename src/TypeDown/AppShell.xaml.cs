using Windows.UI.Xaml.Controls;

namespace TypeDown
{
    public sealed partial class AppShell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        public void SetContentFrame(Frame frame)
        {
            _view.Content = frame;
        }
    }
}
