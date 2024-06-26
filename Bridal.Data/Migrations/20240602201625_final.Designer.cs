﻿// <auto-generated />
using System;
using Bridal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bridal.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240602201625_final")]
    partial class final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bridal.Core.Entities.BridalClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateWedding")
                        .HasColumnType("datetime2");

                    b.Property<int>("DressmakerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BridalList");
                });

            modelBuilder.Entity("Bridal.Core.Entities.Dressmaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("experience")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DressmakerList");
                });

            modelBuilder.Entity("Bridal.Core.Entities.QueueBridal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BridalId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateQueue")
                        .HasColumnType("datetime2");

                    b.Property<int>("DressmakerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BridalId");

                    b.HasIndex("DressmakerId");

                    b.ToTable("QueueBridalList");
                });

            modelBuilder.Entity("Bridal.Core.Entities.QueueBridal", b =>
                {
                    b.HasOne("Bridal.Core.Entities.BridalClass", "Bridal")
                        .WithMany()
                        .HasForeignKey("BridalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bridal.Core.Entities.Dressmaker", "Dressmaker")
                        .WithMany()
                        .HasForeignKey("DressmakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bridal");

                    b.Navigation("Dressmaker");
                });
#pragma warning restore 612, 618
        }
    }
}
