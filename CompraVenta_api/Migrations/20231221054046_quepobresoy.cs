using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompraVentaapi.Migrations
{
    /// <inheritdoc />
    public partial class quepobresoy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interesados",
                columns: table => new
                {
                    InteresadoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CorreoElectronico = table.Column<string>(type: "TEXT", nullable: false),
                    Publicacion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interesados", x => x.InteresadoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interesados");
        }
    }
}
