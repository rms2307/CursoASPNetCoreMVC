using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoASPNetCoreMVC.Migrations
{
    public partial class DepartmentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Department",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Department");
        }
    }
}
