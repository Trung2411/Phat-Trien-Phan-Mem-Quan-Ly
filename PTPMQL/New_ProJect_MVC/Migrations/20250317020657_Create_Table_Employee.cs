using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace New_ProJect_MVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employee",
                newName: "EmployeeEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Person_PersonId",
                table: "Employee",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Person_PersonId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmployeeEmail",
                table: "Employee",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employee",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Employee",
                type: "TEXT",
                nullable: true);
        }
    }
}
