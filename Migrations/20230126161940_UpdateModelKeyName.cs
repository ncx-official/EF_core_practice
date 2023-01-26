using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcorepractice.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelKeyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Employee_id",
                table: "Employee",
                newName: "employee_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Employee",
                newName: "Employee_id");
        }
    }
}
