namespace MainApplication.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string? WarehouseName { get; set; }
        public int Capacity { get; set; }
        public List<Chemical>? Chemicals { get; set; }
        
    }
}