using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class UserSaleConfiguration : IEntityTypeConfiguration<UserSale>
    {
        public void Configure(EntityTypeBuilder<UserSale> builder)
        {
            builder.ToTable("UserSales");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");
            builder.Property(u => u.UserId).HasColumnType("uuid");
            builder.Property(u => u.SaleId).HasColumnType("uuid");
        }
    }
}
