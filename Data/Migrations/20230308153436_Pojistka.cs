using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspWrong.Data.Migrations
{
    /// <inheritdoc />
    public partial class Pojistka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pojistka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PojistenyId = table.Column<int>(type: "int", nullable: false),
                    Majetek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Osoby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zivot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uraz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Predmet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Od = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Do = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pojistka", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pojistka");
        }
    }
}
