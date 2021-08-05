using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoASPNetCoreMVC.Migrations
{
    public partial class ErrorName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Department",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Department",
                newName: "Nome");
        }
    }
}
