using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudApi.Migrations
{
    public partial class values : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Age",
                table: "TreeModels",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Climate",
                table: "TreeModels",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "TreeModels");

            migrationBuilder.DropColumn(
                name: "Climate",
                table: "TreeModels");
        }
    }
}
