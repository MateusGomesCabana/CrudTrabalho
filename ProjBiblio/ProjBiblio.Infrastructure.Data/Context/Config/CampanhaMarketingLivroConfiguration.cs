using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjBiblio.Domain.Entities;

namespace ProjBiblio.Infrastructure.Data.Context.Config
{
    public class CampanhaMarketingLivroConfiguration : IEntityTypeConfiguration<CampanhaMarketingLivro>
    {
        public void Configure(EntityTypeBuilder<CampanhaMarketingLivro> builder)
        {
            #region CampanhaMarketingLivro

            //a Gera Chave Primaria Composta
            builder.HasKey(bc => new { bc.CampanhaMarketingID, bc.LivroID });

            builder.HasOne(bc => bc.CampanhaMarketing)
                .WithMany(b => b.CampanhaMarketingLivro)
                .HasForeignKey(bc => bc.CampanhaMarketingID);

            builder.HasOne(bc => bc.Livro)
                .WithMany(c => c.CampanhaMarketingLivro)
                .HasForeignKey(bc => bc.LivroID);

            #endregion
        }
    }
}