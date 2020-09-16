using IDRMDesktopUI.Models;
using System.Threading.Tasks;

namespace IDRMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}