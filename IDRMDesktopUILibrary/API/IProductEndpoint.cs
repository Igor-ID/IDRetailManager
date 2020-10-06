using IDRMDesktopUILibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IDRMDesktopUILibrary.API
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}