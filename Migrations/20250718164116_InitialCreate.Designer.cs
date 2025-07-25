﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MuitaCoisaCSharp.Models;

#nullable disable

namespace MuitaCoisaCSharp.Migrations
{
    [DbContext(typeof(MuitasCoisasDbContext))]
    [Migration("20250718164116_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DayDiva", b =>
                {
                    b.Property<Guid>("DaysID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DivasID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DaysID", "DivasID");

                    b.HasIndex("DivasID");

                    b.ToTable("DayDiva", (string)null);
                });

            modelBuilder.Entity("MuitaCoisaCSharp.Models.Day", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DoneAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("MuitaCoisaCSharp.Models.Diva", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Divas");
                });

            modelBuilder.Entity("DayDiva", b =>
                {
                    b.HasOne("MuitaCoisaCSharp.Models.Day", null)
                        .WithMany()
                        .HasForeignKey("DaysID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MuitaCoisaCSharp.Models.Diva", null)
                        .WithMany()
                        .HasForeignKey("DivasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
