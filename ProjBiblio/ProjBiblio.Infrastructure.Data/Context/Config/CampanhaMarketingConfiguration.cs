using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjBiblio.Domain.Entities;

namespace ProjBiblio.Infrastructure.Data.Context.Config
{
    public class CampanhaMarketingConfiguration : IEntityTypeConfiguration<CampanhaMarketing>
    {
        public void Configure(EntityTypeBuilder<CampanhaMarketing> builder)
        {
            builder.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(t => t.DataInicio)
                .IsRequired();

            builder.Property(t => t.DataFim)
                .IsRequired();    
           
        }
    }
}