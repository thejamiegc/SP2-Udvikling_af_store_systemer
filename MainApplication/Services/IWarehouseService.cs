using System.Threading.Tasks;
using MainApplication.Repositories;

namespace MainApplication.Services
{
    public interface IWarehouseService
    {
        Task<bool> ValidateTicketAsync(string code);
    }
    
}