using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.Annotations;

namespace MainApplication.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [SwaggerSchema(ReadOnly = true)]
        public int Id { get; set; }
        public bool IsValid { get; set; }
        public string? DepotName { get; set; }

        [ForeignKey("WarehouseId")]
        public Warehouse? ShipmentDetails { get; set; }
        public int? WarehouseId { get; set; }

        [Required]
        public string Code { get; set; } = string.Empty;
    }
}