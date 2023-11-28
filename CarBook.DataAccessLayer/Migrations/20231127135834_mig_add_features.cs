using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_features : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "CarFeatures",
                newName: "HasFeature9");

            migrationBuilder.RenameColumn(
                name: "HasFeature",
                table: "CarFeatures",
                newName: "HasFeature8");

            migrationBuilder.RenameColumn(
                name: "FeatureName",
                table: "CarFeatures",
                newName: "FeatureName9");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName1",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName10",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName11",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName12",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName13",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName14",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName15",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName2",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName3",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName4",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName5",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName6",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName7",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureName8",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature1",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature10",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature11",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature12",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature13",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature14",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature15",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature2",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature3",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature4",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature5",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature6",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasFeature7",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeatureName1",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName10",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName11",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName12",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName13",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName14",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName15",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName2",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName3",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName4",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName5",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName6",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName7",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "FeatureName8",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature1",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature10",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature11",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature12",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature13",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature14",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature15",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature2",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature3",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature4",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature5",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature6",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "HasFeature7",
                table: "CarFeatures");

            migrationBuilder.RenameColumn(
                name: "HasFeature9",
                table: "CarFeatures",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "HasFeature8",
                table: "CarFeatures",
                newName: "HasFeature");

            migrationBuilder.RenameColumn(
                name: "FeatureName9",
                table: "CarFeatures",
                newName: "FeatureName");
        }
    }
}
