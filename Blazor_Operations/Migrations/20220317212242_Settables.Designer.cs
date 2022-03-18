﻿// <auto-generated />
using System;
using Blazor_Operations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blazor_Operations.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220317212242_Settables")]
    partial class Settables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blazor_Operations.Data.Device", b =>
                {
                    b.Property<int>("DeviceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("DeviceID");

                    b.ToTable("DevicesTable");
                });

            modelBuilder.Entity("Blazor_Operations.Data.Operations", b =>
                {
                    b.Property<int>("OperationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DeviceID")
                        .HasColumnType("int");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderInWhichToPerform")
                        .HasColumnType("int");

                    b.HasKey("OperationID");

                    b.HasIndex("DeviceID");

                    b.ToTable("OperationsTable");
                });

            modelBuilder.Entity("Blazor_Operations.Data.Operations", b =>
                {
                    b.HasOne("Blazor_Operations.Data.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceID");

                    b.Navigation("Device");
                });
#pragma warning restore 612, 618
        }
    }
}
