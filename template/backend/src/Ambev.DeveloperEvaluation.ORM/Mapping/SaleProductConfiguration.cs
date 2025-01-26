using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class SaleProductConfiguration : IEntityTypeConfiguration<SaleProduct>
    {
        public void Configure(EntityTypeBuilder<SaleProduct> builder)
        {
            builder.ToTable("SalesProducts");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");
            builder.Property(u => u.Sale_Id).HasColumnType("uuid");
            builder.Property(u => u.Product_Id).HasColumnType("uuid");

            builder.Property(u => u.Quantity);
        }
    }
}
