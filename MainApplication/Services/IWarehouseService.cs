using System.Threading.Tasks;
using MainApplication.Models;
using MainApplication.Repositories;

namespace MainApplication.Services
{
    public interface IWarehouseService
{
    Task<bool> ValidateTicketAsync(string code);
    Task<IEnumerable<Ticket>> GetAllTicketsAsync();
}
    
}