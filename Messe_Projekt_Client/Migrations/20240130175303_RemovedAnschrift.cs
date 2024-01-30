using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Messe_Projekt_Client.Migrations
{
    /// <inheritdoc />
    public partial class RemovedAnschrift : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Firma_Anschrift_AnschriftId",
                table: "Firma");

            migrationBuilder.DropIndex(
                name: "IX_Firma_AnschriftId",
                table: "Firma");

            migrationBuilder.DropColumn(
                name: "AnschriftId",
                table: "Firma");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnschriftId",
                table: "Firma",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Firma_AnschriftId",
                table: "Firma",
                column: "AnschriftId");

            migrationBuilder.AddForeignKey(
                name: "FK_Firma_Anschrift_AnschriftId",
                table: "Firma",
                column: "AnschriftId",
                principalTable: "Anschrift",
                principalColumn: "AnschriftId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
