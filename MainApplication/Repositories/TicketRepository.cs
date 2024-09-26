using MainApplication.Data;
using MainApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace MainApplication.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly WarehouseContext _context;

        public TicketRepository(WarehouseContext context)
        {
            _context = context;
        }

        public async Task<Ticket?> GetTicketByCodeAsync(string code)
        {
            return await _context.Tickets.FirstOrDefaultAsync(t => t.Code == code);
        }

        public async Task UpdateTicketAsync(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
            await _context.SaveChangesAsync();
        }
        
        public async Task<IEnumerable<Ticket>> GetAllTicketsAsync()
        {
            return await _context.Tickets.ToListAsync();
        }
    }
}