using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Messe_Projekt_Client.Migrations
{
    /// <inheritdoc />
    public partial class AddConfirmation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                table: "Kunde",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirmed",
                table: "Kunde");
        }
    }
}
