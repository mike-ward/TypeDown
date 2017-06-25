using System;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace TypeDown.Services
{
    public class AlertMessageService : IAlertMessageService
    {
        private static bool _isShowing;

        public async Task ShowAsync(string message, string title)
        {
            // Only show one dialog at a time.
            if (!_isShowing)
            {
                var messageDialog = new MessageDialog(message, title);
                _isShowing = true;
                await messageDialog.ShowAsync();
                _isShowing = false;
            }
        }
    }
}
