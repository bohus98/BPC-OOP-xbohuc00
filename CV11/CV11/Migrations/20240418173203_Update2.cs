using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV11.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZkratkaPredmetu",
                table: "Hodnoceni",
                newName: "Zkratka");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Zkratka",
                table: "Hodnoceni",
                newName: "ZkratkaPredmetu");
        }
    }
}
