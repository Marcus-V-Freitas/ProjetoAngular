using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoAngular.Migrations
{
    public partial class addRestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hours",
                table: "Restaurants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Hours",
                table: "Restaurants");
        }
    }
}
