using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompraVentaapi.Migrations
{
    /// <inheritdoc />
    public partial class harcodeo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "registro",
                table: "Interesados",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "registro",
                table: "Interesados");
        }
    }
}
