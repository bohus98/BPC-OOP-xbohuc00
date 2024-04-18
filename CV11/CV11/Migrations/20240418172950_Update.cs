using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV11.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ZkratkaPredmetu",
                table: "Hodnoceni",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZkratkaPredmetu",
                table: "Hodnoceni");
        }
    }
}
