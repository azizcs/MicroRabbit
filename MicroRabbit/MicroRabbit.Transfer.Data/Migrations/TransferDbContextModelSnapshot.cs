﻿// <auto-generated />
using MicroRabbit.Transfer.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroRabbit.Transfer.Data.Migrations
{
    [DbContext(typeof(TransferDbContext))]
    partial class TransferDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("MicroRabbit.Transfer.Domain.Models.TransferLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FromAccount")
                        .HasColumnType("int");

                    b.Property<int>("ToAccount")
                        .HasColumnType("int");

                    b.Property<decimal>("TransferAmount")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("TransferLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
