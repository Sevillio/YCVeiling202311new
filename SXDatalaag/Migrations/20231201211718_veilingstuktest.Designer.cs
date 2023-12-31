﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SXDatalaag;

#nullable disable

namespace SXDatalaag.Migrations
{
    [DbContext(typeof(DatabaseVeilingContext))]
    [Migration("20231201211718_veilingstuktest")]
    partial class veilingstuktest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SXDatalaag.Veiling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Duratie")
                        .HasColumnType("int");

                    b.Property<int>("LaatsteBod")
                        .HasColumnType("int");

                    b.Property<int>("MinimumBod")
                        .HasColumnType("int");

                    b.Property<int>("OpeningsBod")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDatumTijd")
                        .HasColumnType("datetime2");

                    b.Property<int>("veilingstukId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("veilingstukId");

                    b.ToTable("Veiling");
                });

            modelBuilder.Entity("SXDatalaag.Veilingstuk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aanbieder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categorie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gewicht")
                        .HasColumnType("int");

                    b.Property<int>("Hoogte")
                        .HasColumnType("int");

                    b.Property<int>("Lengte")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Veilingstuk");
                });

            modelBuilder.Entity("SXDatalaag.Veiling", b =>
                {
                    b.HasOne("SXDatalaag.Veilingstuk", "veilingstuk")
                        .WithMany()
                        .HasForeignKey("veilingstukId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("veilingstuk");
                });
#pragma warning restore 612, 618
        }
    }
}
