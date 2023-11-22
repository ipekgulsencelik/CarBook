using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_update_car : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GearType",
                table: "Cars",
                newName: "Transmission");

            migrationBuilder.AddColumn<byte>(
                name: "Door",
                table: "Cars",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "Luggage",
                table: "Cars",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "Seat",
                table: "Cars",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Door",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Luggage",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Seat",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Transmission",
                table: "Cars",
                newName: "GearType");
        }
    }
}
