﻿// <auto-generated />
using System;
using CV11.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CV11.Migrations
{
    [DbContext(typeof(VyukaContext))]
    [Migration("20240418173203_Update2")]
    partial class Update2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CV11.EFCore.Hodnoceni", b =>
                {
                    b.Property<int>("HodnoceniId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HodnoceniId"));

                    b.Property<DateTime>("DatumHodnoceni")
                        .HasColumnType("datetime2");

                    b.Property<int>("HodnoceniBody")
                        .HasColumnType("int");

                    b.Property<int>("PredmetId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Zkratka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HodnoceniId");

                    b.HasIndex("PredmetId");

                    b.HasIndex("StudentId");

                    b.ToTable("Hodnoceni");
                });

            modelBuilder.Entity("CV11.EFCore.Predmet", b =>
                {
                    b.Property<int>("PredmetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PredmetId"));

                    b.Property<string>("NazevPredmetu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zkratka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PredmetId");

                    b.ToTable("Predmety");
                });

            modelBuilder.Entity("CV11.EFCore.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime>("DatumNarozeni")
                        .HasColumnType("datetime2");

                    b.Property<string>("Jmeno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prijmeni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Studenti");
                });

            modelBuilder.Entity("CV11.EFCore.Zapis", b =>
                {
                    b.Property<int>("ZapisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZapisId"));

                    b.Property<int>("PredmetId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("ZapisId");

                    b.HasIndex("PredmetId");

                    b.HasIndex("StudentId");

                    b.ToTable("Zapisy");
                });

            modelBuilder.Entity("CV11.EFCore.Hodnoceni", b =>
                {
                    b.HasOne("CV11.EFCore.Predmet", "Predmet")
                        .WithMany("Hodnoceni")
                        .HasForeignKey("PredmetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CV11.EFCore.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predmet");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CV11.EFCore.Zapis", b =>
                {
                    b.HasOne("CV11.EFCore.Predmet", "Predmet")
                        .WithMany("Zapisy")
                        .HasForeignKey("PredmetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CV11.EFCore.Student", "Student")
                        .WithMany("Zapisy")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predmet");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CV11.EFCore.Predmet", b =>
                {
                    b.Navigation("Hodnoceni");

                    b.Navigation("Zapisy");
                });

            modelBuilder.Entity("CV11.EFCore.Student", b =>
                {
                    b.Navigation("Zapisy");
                });
#pragma warning restore 612, 618
        }
    }
}
