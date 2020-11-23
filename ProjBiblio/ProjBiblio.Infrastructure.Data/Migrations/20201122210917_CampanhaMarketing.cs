using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProjBiblio.Infrastructure.Data.Migrations
{
    public partial class CampanhaMarketing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CampanhaMarketing",
                columns: table => new
                {
                    CampanhaMarketingID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(maxLength: 200, nullable: false),
                    DataInicio = table.Column<string>(nullable: false),
                    DataFim = table.Column<string>(nullable: false),
                    PercentualDesconto = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanhaMarketing", x => x.CampanhaMarketingID);
                });

            migrationBuilder.CreateTable(
                name: "CampanhaMarketingLivro",
                columns: table => new
                {
                    CampanhaMarketingID = table.Column<int>(nullable: false),
                    LivroID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanhaMarketingLivro", x => new { x.CampanhaMarketingID, x.LivroID });
                    table.ForeignKey(
                        name: "FK_CampanhaMarketingLivro_CampanhaMarketing_CampanhaMarketingID",
                        column: x => x.CampanhaMarketingID,
                        principalTable: "CampanhaMarketing",
                        principalColumn: "CampanhaMarketingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampanhaMarketingLivro_Livro_LivroID",
                        column: x => x.LivroID,
                        principalTable: "Livro",
                        principalColumn: "LivroID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampanhaMarketingLivro_LivroID",
                table: "CampanhaMarketingLivro",
                column: "LivroID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampanhaMarketingLivro");

            migrationBuilder.DropTable(
                name: "CampanhaMarketing");
        }
    }
}
