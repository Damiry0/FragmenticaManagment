﻿// <auto-generated />
using System;
using FragmenticaManagmentCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FragmenticaManagmentMigrations.Migrations
{
    [DbContext(typeof(FragmenticaContext))]
    partial class FragmenticaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FragmenticaManagmentCore.Domain.Perfume", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.HasKey("Guid");

                    b.ToTable("Perfumes");
                });

            modelBuilder.Entity("FragmenticaManagmentCore.Domain.Perfume", b =>
                {
                    b.OwnsMany("FragmenticaManagmentCore.Domain.Accord", "Accords", b1 =>
                        {
                            b1.Property<Guid>("PerfumeGuid")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<float>("Percentage")
                                .HasColumnType("real");

                            b1.HasKey("PerfumeGuid", "Id");

                            b1.ToTable("Accord");

                            b1.WithOwner()
                                .HasForeignKey("PerfumeGuid");
                        });

                    b.Navigation("Accords");
                });
#pragma warning restore 612, 618
        }
    }
}
