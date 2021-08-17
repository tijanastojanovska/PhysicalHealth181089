using Microsoft.EntityFrameworkCore.Migrations;

namespace DnickPhysicalHealth181089.Data.Migrations
{
    public partial class imagePlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Plan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Plan");
        }
    }
}
