using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using System;
using System.Collections.Generic;
namespace WebApi.Data;

public class WebApiDBContext : DbContext
{
    public WebApiDBContext()
    {

    }

    public WebApiDBContext(DbContextOptions<WebApiDBContext> options) : base(options) { }

    public virtual DbSet<Contribuyentes> Contribuyentes { get; set; }

    public virtual DbSet<Comprobante> Comprobante { get; set; }

  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comprobante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comproba__3214EC075A97BB7C");

            entity.ToTable("Comprobante");

            entity.Property(e => e.Itbis18).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Ncf)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("NCF");

            entity.HasOne(d => d.Contribuyente).WithMany(p => p.Comprobante)
                .HasForeignKey(d => d.ContribuyenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comproban__Contr__1273C1CD");
        });

        modelBuilder.Entity<Contribuyentes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contribu__3214EC07BA13D191");

            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RncCedula)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        
    }

    


}




