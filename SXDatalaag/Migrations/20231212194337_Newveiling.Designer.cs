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
    [Migration("20231212194337_Newveiling")]
    partial class Newveiling
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SXDatalaag.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefoon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("SXDatalaag.Bod", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Prijs")
                        .HasColumnType("int");

                    b.Property<int>("VeilingId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("AccountId");

                    b.HasIndex("VeilingId");

                    b.ToTable("Bod");
                });

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

                    b.Property<int>("VeilingstukId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VeilingstukId");

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

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

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

                    b.Property<string>("StukName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Veilingstuk");
                });

            modelBuilder.Entity("SXDatalaag.Bod", b =>
                {
                    b.HasOne("SXDatalaag.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SXDatalaag.Veiling", "Veiling")
                        .WithMany()
                        .HasForeignKey("VeilingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Veiling");
                });

            modelBuilder.Entity("SXDatalaag.Veiling", b =>
                {
                    b.HasOne("SXDatalaag.Veilingstuk", "Veilingstuk")
                        .WithMany()
                        .HasForeignKey("VeilingstukId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veilingstuk");
                });

            modelBuilder.Entity("SXDatalaag.Veilingstuk", b =>
                {
                    b.HasOne("SXDatalaag.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}
