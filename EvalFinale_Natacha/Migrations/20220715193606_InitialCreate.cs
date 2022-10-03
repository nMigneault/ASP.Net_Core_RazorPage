using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvalFinale_Natacha.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommandesFaitesPar",
                columns: table => new
                {
                    CommandeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeID = table.Column<int>(type: "int", nullable: false),
                    DateCommande = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRequise = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnvoi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdresseEnvoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VilleEnvoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodePostalEnvoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaysEnvoi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandesFaitesPar", x => x.CommandeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommandesFaitesPar");
        }
    }
}
