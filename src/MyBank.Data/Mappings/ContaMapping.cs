using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBank.Business.Models;

namespace MyBank.Data.Mappings;

public class ContaMapping : IEntityTypeConfiguration<Conta>
{
    public void Configure(EntityTypeBuilder<Conta> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Nome)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(c => c.TipoConta)
            .IsRequired();

        builder.Property(c => c.Saldo)
            .HasColumnType("decimal")
            .HasPrecision(7,2);

        builder.Property(c => c.DataAbertura)
            .HasColumnType("date");

        builder.ToTable("Contas");

    }
}