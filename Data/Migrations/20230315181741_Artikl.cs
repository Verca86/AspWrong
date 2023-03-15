using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspWrong.Data.Migrations
{
    /// <inheritdoc />
    public partial class Artikl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Article1_PojistkaID",
                table: "Article1");

            migrationBuilder.CreateIndex(
                name: "IX_Article1_PojistkaID",
                table: "Article1",
                column: "PojistkaID",
                unique: true,
                filter: "[PojistkaID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Article1_PojistkaID",
                table: "Article1");

            migrationBuilder.CreateIndex(
                name: "IX_Article1_PojistkaID",
                table: "Article1",
                column: "PojistkaID");
        }
    }
}
