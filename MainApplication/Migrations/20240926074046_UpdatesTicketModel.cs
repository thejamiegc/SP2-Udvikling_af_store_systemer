using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MainApplication.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesTicketModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "capacity",
                table: "Warehouses",
                newName: "Capacity");

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseName",
                table: "Warehouses",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsValid = table.Column<bool>(type: "INTEGER", nullable: false),
                    DepotName = table.Column<string>(type: "TEXT", nullable: true),
                    WarehouseId = table.Column<int>(type: "INTEGER", nullable: true),
                    Code = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_WarehouseId",
                table: "Tickets",
                column: "WarehouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "Warehouses",
                newName: "capacity");

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseName",
                table: "Warehouses",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
