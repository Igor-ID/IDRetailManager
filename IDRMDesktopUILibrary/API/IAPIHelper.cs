using IDRMDesktopUI.Models;
using System.Threading.Tasks;

namespace IDRMDesktopUILibrary.API
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}