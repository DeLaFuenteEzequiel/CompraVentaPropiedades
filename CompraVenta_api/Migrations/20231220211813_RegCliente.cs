using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompraVentaapi.Migrations
{
    /// <inheritdoc />
    public partial class RegCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Registro",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Registro",
                table: "Usuarios");
        }
    }
}
