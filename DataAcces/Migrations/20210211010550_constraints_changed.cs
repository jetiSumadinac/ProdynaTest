using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcces.Migrations
{
    public partial class constraints_changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_NewsItems_AuthorId",
                table: "NewsItems");

            migrationBuilder.CreateIndex(
                name: "IX_NewsItems_AuthorId",
                table: "NewsItems",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_NewsItems_AuthorId",
                table: "NewsItems");

            migrationBuilder.CreateIndex(
                name: "IX_NewsItems_AuthorId",
                table: "NewsItems",
                column: "AuthorId",
                unique: true);
        }
    }
}
