using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;
namespace produccion.Configurations;
public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
{
    public void Configure(EntityTypeBuilder<Cargo> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("cargo");

        builder.Property(e => e.Descripcion)
            .HasMaxLength(50)
            .HasColumnName("descripcion");
        builder.Property(e => e.SueldoBase).HasColumnName("sueldo_base");
    }
}