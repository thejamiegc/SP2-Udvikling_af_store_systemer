using MainApplication.Models;
using MainApplication.Repositories;
using MainApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace MainApplication.Controllers;

[Route("api/Warehouse")]
[ApiController]
public class WarehouseController(IWarehouseRepository warehouseRepository, IWarehouseService warehouseService)
    : ControllerBase
{
    [HttpGet(Name = "GetWarehouse")]
    public async Task<ActionResult<Warehouse>> GetWarehouseList()
    {
        var warehouses = await warehouseRepository.GetWarehousesAsync();
        return Ok(warehouses);
    }
    
    [HttpGet("ValidateTicket/{code}")]
    public async Task<ActionResult<bool>> ValidateTicket(string code)
    {
        var isValid = await warehouseService.ValidateTicketAsync(code);
        return Ok(isValid);
    }

    [HttpGet("GetAllTickets")]
    public async Task<ActionResult<IEnumerable<Ticket>>> GetAllTickets()
    {
        var tickets = await warehouseService.GetAllTicketsAsync();
        return Ok(tickets);
    
    } 
}