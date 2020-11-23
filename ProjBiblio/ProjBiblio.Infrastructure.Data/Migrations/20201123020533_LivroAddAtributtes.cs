using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjBiblio.Infrastructure.Data.Migrations
{
    public partial class LivroAddAtributtes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Livro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Edicao",
                table: "Livro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Editora",
                table: "Livro",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Pagina",
                table: "Livro",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Edicao",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Editora",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Pagina",
                table: "Livro");
        }
    }
}
