using MainApplication.Models;
using MainApplication.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MainApplication.Controllers;

[Route("api/Warehouse")]
[ApiController]
public class WarehouseController : ControllerBase
{
    private readonly IWarehouseRepository _warehouseRepository;

    public WarehouseController(IWarehouseRepository warehouseRepository)
    {
        _warehouseRepository = warehouseRepository;
    }


    [HttpGet(Name = "GetWarehouse")]
    public async Task<ActionResult<Warehouse>> GetWarehouseList()
    {
        var warehouses = await _warehouseRepository.GetWarehousesAsync();
        return Ok(warehouses);
    }
}