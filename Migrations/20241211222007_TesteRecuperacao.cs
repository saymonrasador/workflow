using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pipeline.Migrations
{
    /// <inheritdoc />
    public partial class TesteRecuperacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Recuperacao",
                table: "clientes",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recuperacao",
                table: "clientes");
        }
    }
}
