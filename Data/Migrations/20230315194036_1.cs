using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspWrong.Data.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article1_Pojistka_PojistkaID",
                table: "Article1");

            migrationBuilder.DropIndex(
                name: "IX_Article1_PojistkaID",
                table: "Article1");

            migrationBuilder.DropColumn(
                name: "PojistkaID",
                table: "Article1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PojistkaID",
                table: "Article1",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Article1_PojistkaID",
                table: "Article1",
                column: "PojistkaID",
                unique: true,
                filter: "[PojistkaID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Article1_Pojistka_PojistkaID",
                table: "Article1",
                column: "PojistkaID",
                principalTable: "Pojistka",
                principalColumn: "Id");
        }
    }
}
