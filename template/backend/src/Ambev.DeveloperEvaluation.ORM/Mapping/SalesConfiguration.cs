using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class SalesConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ToTable("Sales");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(u => u.CreatedAt).IsRequired();
        builder.Property(u => u.TotalSale).IsRequired();
        builder.Property(u => u.Discount);
        builder.Property(u => u.TotalSaleItems).IsRequired();
        builder.Property(u => u.Canceled).IsRequired();
        builder.Property(u => u.UpdatedAt);
    }
}
