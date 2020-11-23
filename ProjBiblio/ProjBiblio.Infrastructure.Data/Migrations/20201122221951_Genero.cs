using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProjBiblio.Infrastructure.Data.Migrations
{
    public partial class Genero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GeneroID",
                table: "Livro",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    GeneroID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.GeneroID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_GeneroID",
                table: "Livro",
                column: "GeneroID");

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Genero_GeneroID",
                table: "Livro",
                column: "GeneroID",
                principalTable: "Genero",
                principalColumn: "GeneroID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Genero_GeneroID",
                table: "Livro");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropIndex(
                name: "IX_Livro_GeneroID",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "GeneroID",
                table: "Livro");
        }
    }
}
