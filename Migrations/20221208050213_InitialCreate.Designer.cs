﻿// <auto-generated />
using CIDM3312_FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIDM3312FinalProject.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20221208050213_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("CIDM3312_FinalProject.Models.CollectionLayer", b =>
                {
                    b.Property<int>("CollectionLayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CollectionCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CollectionLabel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CollectionLayerId");

                    b.ToTable("CollectionLayer");
                });

            modelBuilder.Entity("CIDM3312_FinalProject.Models.Facility", b =>
                {
                    b.Property<int>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FacilityCode")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("TEXT");

                    b.Property<string>("FacilityName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.Property<int>("GwtgFacilityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FacilityId");

                    b.ToTable("Facility");
                });

            modelBuilder.Entity("CIDM3312_FinalProject.Models.FacilityCollection", b =>
                {
                    b.Property<int>("FcRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CollectionLayerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FacilityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FcRowId");

                    b.HasIndex("CollectionLayerId");

                    b.HasIndex("FacilityId");

                    b.ToTable("FacilityCollection");
                });

            modelBuilder.Entity("CIDM3312_FinalProject.Models.FacilityCollection", b =>
                {
                    b.HasOne("CIDM3312_FinalProject.Models.CollectionLayer", "CollectionLayer")
                        .WithMany("FacilityCollections")
                        .HasForeignKey("CollectionLayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CIDM3312_FinalProject.Models.Facility", "Facility")
                        .WithMany("FacilityCollections")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CollectionLayer");

                    b.Navigation("Facility");
                });

            modelBuilder.Entity("CIDM3312_FinalProject.Models.CollectionLayer", b =>
                {
                    b.Navigation("FacilityCollections");
                });

            modelBuilder.Entity("CIDM3312_FinalProject.Models.Facility", b =>
                {
                    b.Navigation("FacilityCollections");
                });
#pragma warning restore 612, 618
        }
    }
}
