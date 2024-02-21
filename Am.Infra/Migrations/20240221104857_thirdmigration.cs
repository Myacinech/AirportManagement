using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Am.Infra.Migrations
{
    /// <inheritdoc />
    public partial class thirdmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Airline",
                table: "Planes",
                newName: "Airlinelogo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Airlinelogo",
                table: "Planes",
                newName: "Airline");
        }
    }
}
