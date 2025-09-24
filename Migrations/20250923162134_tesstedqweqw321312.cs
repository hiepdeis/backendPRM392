using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backendPRM.Migrations
{
    /// <inheritdoc />
    public partial class tesstedqweqw321312 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fucksdhsj",
                table: "Users",
                newName: "PasswordHash");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "fucksdhsj");
        }
    }
}
