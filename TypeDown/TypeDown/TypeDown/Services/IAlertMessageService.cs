using System.Threading.Tasks;

namespace TypeDown.Services
{
    public interface IAlertMessageService
    {
        Task ShowAsync(string message, string title);
    }
}