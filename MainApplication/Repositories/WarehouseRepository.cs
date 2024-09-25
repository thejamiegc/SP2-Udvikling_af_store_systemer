using MainApplication.Data;
using MainApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace MainApplication.Repositories
{
    public class WarehouseRepository(WarehouseContext context) : IWarehouseRepository
    {
        private readonly WarehouseContext _context = context;

        public async Task<List<Warehouse>> GetWarehousesAsync()
        {
            return await _context.Warehouses.Select(w => new Warehouse
            {
                Id = w.Id,
                WarehouseName = w.WarehouseName,
                capacity = w.capacity,
                Chemicals = w.Chemicals
            }).ToListAsync<Warehouse>();
        }
    }
}