using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatformService.Migrations
{
    /// <inheritdoc />
    public partial class changedtablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PlatForm",
                table: "PlatForm");

            migrationBuilder.RenameTable(
                name: "PlatForm",
                newName: "Platform");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platform",
                table: "Platform",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Platform",
                table: "Platform");

            migrationBuilder.RenameTable(
                name: "Platform",
                newName: "PlatForm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlatForm",
                table: "PlatForm",
                column: "Id");
        }
    }
}
