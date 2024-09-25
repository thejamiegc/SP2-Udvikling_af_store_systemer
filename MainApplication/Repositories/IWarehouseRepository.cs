using MainApplication.Models;

namespace MainApplication.Repositories;

public interface IWarehouseRepository
{ 
    Task<List<Warehouse>> GetWarehousesAsync();
}