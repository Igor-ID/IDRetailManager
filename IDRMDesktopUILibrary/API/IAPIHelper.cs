using IDRMDesktopUI.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace IDRMDesktopUILibrary.API
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        void LogOffUser();
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}