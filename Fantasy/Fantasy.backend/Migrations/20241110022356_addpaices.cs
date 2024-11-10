using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fantasy.backend.Migrations
{
    /// <inheritdoc />
    public partial class addpaices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paices", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paices_nombre",
                table: "Paices",
                column: "nombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paices");
        }
    }
}
