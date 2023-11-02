using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;
namespace produccion.Configurations;
 
    public class DetalleVentumConfiguration : IEntityTypeConfiguration<DetalleVentum>
    {
        public void Configure(EntityTypeBuilder<DetalleVentum> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("detalle_venta");

            builder.HasIndex(e => e.IdProductoFk, "IX_detalle_venta_IdProductoFk");

            builder.HasIndex(e => e.IdTallaFk, "IX_detalle_venta_IdTallaFk");

            builder.HasIndex(e => e.IdVentaFk, "IX_detalle_venta_IdVentaFk");

            builder.Property(e => e.Cantidad).HasColumnName("cantidad");
            builder.Property(e => e.ValorUnit).HasColumnName("valor_unit");

            builder.HasOne(d => d.IdProductoFkNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdProductoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(d => d.IdTallaFkNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdTallaFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(d => d.IdVentaFkNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdVentaFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
         }
    }