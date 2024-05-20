using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudgetBomb.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Accounts",
                newName: "BankName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BankName",
                table: "Accounts",
                newName: "Name");
        }
    }
}
