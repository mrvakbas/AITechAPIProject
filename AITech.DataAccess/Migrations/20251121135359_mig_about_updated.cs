using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AITech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_about_updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IamgeUrl",
                table: "Banners",
                newName: "ImageUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Banners",
                newName: "IamgeUrl");
        }
    }
}
