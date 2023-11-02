using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;
namespace produccion.Configurations;
public class PaiConfiguration : IEntityTypeConfiguration<Pai>
{
    public void Configure(EntityTypeBuilder<Pai> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("pais");

            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
    }
}