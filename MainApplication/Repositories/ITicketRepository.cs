using MainApplication.Models;

namespace MainApplication.Repositories
{
    public interface ITicketRepository
    {
        Task<Ticket?> GetTicketByCodeAsync(string code);
        Task UpdateTicketAsync(Ticket ticket);
    }
}