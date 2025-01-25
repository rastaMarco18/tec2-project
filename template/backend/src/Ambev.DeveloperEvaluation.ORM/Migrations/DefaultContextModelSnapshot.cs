﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    [DbContext(typeof(DefaultContext))]
    partial class DefaultContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Sale", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid")
                    .HasDefaultValueSql("gen_random_uuid()");

                b.Property<DateTime>("CreatedAt")
                    .IsRequired()
                    .HasColumnType("date");

                b.Property<decimal>("TotalSale")
                    .IsRequired()
                    .HasColumnType("numeric(38, 2)");

                b.Property<decimal>("Discount")
                    .IsRequired()
                    .HasColumnType("numeric(38, 2)");

                b.Property<decimal>("TotalSaleItems")
                    .IsRequired()
                    .HasColumnType("numeric(38, 2)");

                b.Property<decimal>("Canceled")
                    .IsRequired()
                    .HasColumnType("boolean");

                b.Property<DateTime>("UpdatedAt")
                   .IsRequired()
                   .HasColumnType("date");

                b.HasKey("Id");

                b.ToTable("Sales", (string)null);
            });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Products", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid")
                    .HasDefaultValueSql("gen_random_uuid()");

                b.Property<DateTime>("CreatedAt")
                    .IsRequired()
                    .HasColumnType("date");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("character varying(100)");

                b.Property<decimal>("Price")
                    .IsRequired()
                    .HasColumnType("numeric(38, 2)");

                b.Property<DateTime>("UpdatedAt")
                    .IsRequired()
                    .HasColumnType("date");

                b.HasKey("Id");

                b.ToTable("Products", (string)null);

#pragma warning restore 612, 618
            });

        }
    }
}
