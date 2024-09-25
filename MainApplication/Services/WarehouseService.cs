using MainApplication.Models;
using MainApplication.Repositories;
using MainApplication.Validator;

namespace MainApplication.Services;

public class WarehouseService : IWarehouseService
{
    private readonly ITicketRepository _ticketRepository;
    private readonly ValidateTicket _validateTicket;

    public WarehouseService(ITicketRepository ticketRepository, ValidateTicket validateTicket)
    {
        _ticketRepository = ticketRepository;
        _validateTicket = validateTicket;
    }

    public async Task<bool> ValidateTicketAsync(string code)
    {
        var isValid = _validateTicket.IsValidTicket(code);
        if (isValid)
        {
            var ticket = await _ticketRepository.GetTicketByCodeAsync(code);
            if (ticket != null)
            {
                ticket.IsValid = true;
                await _ticketRepository.UpdateTicketAsync(ticket);
            }
        }
        return isValid;
    }
}