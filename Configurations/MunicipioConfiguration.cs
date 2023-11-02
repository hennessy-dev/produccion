using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;
namespace produccion.Configurations;
public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
{
    public void Configure(EntityTypeBuilder<Municipio> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("municipio");

            builder.HasIndex(e => e.IdDepartamentoFk, "IX_municipio_IdDepartamentoFk");

            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            builder.HasOne(d => d.IdDepartamentoFkNavigation).WithMany(p => p.Municipios)
                .HasForeignKey(d => d.IdDepartamentoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
    }
}