using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asset.Migrations
{
    /// <inheritdoc />
    public partial class deleteAssetfromTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Assets_CountryId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_ProductId",
                table: "Assets");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_CountryId",
                table: "Assets",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_ProductId",
                table: "Assets",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Assets_CountryId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_ProductId",
                table: "Assets");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_CountryId",
                table: "Assets",
                column: "CountryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Assets_ProductId",
                table: "Assets",
                column: "ProductId",
                unique: true);
        }
    }
}
