using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backendPRM.Migrations
{
    /// <inheritdoc />
    public partial class tesstedqweqw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "fucksdhsj");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fucksdhsj",
                table: "Users",
                newName: "PasswordHash");
        }
    }
}
