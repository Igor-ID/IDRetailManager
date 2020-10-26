using IDRMDesktopUILibrary.Models;
using System.Threading.Tasks;

namespace IDRMDesktopUILibrary.API
{
    public interface ISaleEndpoint
    {
        Task PostSale(SaleModel sale);
    }
}