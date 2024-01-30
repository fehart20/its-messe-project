using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Messe_Projekt_Client.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anschrift",
                columns: table => new
                {
                    AnschriftId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Strasse = table.Column<string>(type: "TEXT", nullable: false),
                    Hausnummer = table.Column<string>(type: "TEXT", nullable: false),
                    Plz = table.Column<int>(type: "INTEGER", nullable: false),
                    Ort = table.Column<string>(type: "TEXT", nullable: false),
                    KundeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anschrift", x => x.AnschriftId);
                });

            migrationBuilder.CreateTable(
                name: "Firma",
                columns: table => new
                {
                    FirmaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AnschriftId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firma", x => x.FirmaId);
                    table.ForeignKey(
                        name: "FK_Firma_Anschrift_AnschriftId",
                        column: x => x.AnschriftId,
                        principalTable: "Anschrift",
                        principalColumn: "AnschriftId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kunde",
                columns: table => new
                {
                    KundeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vorname = table.Column<string>(type: "TEXT", nullable: false),
                    Nachname = table.Column<string>(type: "TEXT", nullable: false),
                    FirmaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunde", x => x.KundeId);
                    table.ForeignKey(
                        name: "FK_Kunde_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "FirmaId");
                });

            migrationBuilder.CreateTable(
                name: "Interesse",
                columns: table => new
                {
                    InteresseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProduktgruppeName = table.Column<string>(type: "TEXT", nullable: false),
                    KundeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interesse", x => x.InteresseId);
                    table.ForeignKey(
                        name: "FK_Interesse_Kunde_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunde",
                        principalColumn: "KundeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anschrift_KundeId",
                table: "Anschrift",
                column: "KundeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Firma_AnschriftId",
                table: "Firma",
                column: "AnschriftId");

            migrationBuilder.CreateIndex(
                name: "IX_Interesse_KundeId",
                table: "Interesse",
                column: "KundeId");

            migrationBuilder.CreateIndex(
                name: "IX_Kunde_FirmaId",
                table: "Kunde",
                column: "FirmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anschrift_Kunde_KundeId",
                table: "Anschrift",
                column: "KundeId",
                principalTable: "Kunde",
                principalColumn: "KundeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anschrift_Kunde_KundeId",
                table: "Anschrift");

            migrationBuilder.DropTable(
                name: "Interesse");

            migrationBuilder.DropTable(
                name: "Kunde");

            migrationBuilder.DropTable(
                name: "Firma");

            migrationBuilder.DropTable(
                name: "Anschrift");
        }
    }
}
