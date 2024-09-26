using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MainApplication.Migrations
{
    public partial class SeedTickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "IsValid", "DepotName", "WarehouseId", "Code" },
                values: new object[,]
                {
                    { 1, false, "Depot 1", 1, "warehouse 1 chemical b" },
                    { 2, true, "Depot 2", 1, "warehouse 1 chemical a" },
                    { 3, false, "Depot 3", 2, "warehouse 2 chemical a" },
                    { 4, true, "Depot 4", 2, "warehouse 2 chemical b" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4 });
        }
    }
}