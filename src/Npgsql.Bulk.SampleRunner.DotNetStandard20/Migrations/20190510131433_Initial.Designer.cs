﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.Bulk.DAL;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using NpgsqlTypes;

namespace Npgsql.Bulk.SampleRunner.DotNetStandard20.Migrations
{
    [DbContext(typeof(BulkContext))]
    [Migration("20190510131433_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Npgsql.Bulk.SampleRunner.DotNetStandard20.DAL.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("address_id");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at");

                    b.Property<NpgsqlRange<DateTime>>("Duration")
                        .HasColumnName("range");

                    b.Property<int?>("ExtraHouseNumber")
                        .HasColumnName("extra_house_number");

                    b.Property<int>("HouseNumber")
                        .HasColumnName("house_number");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnName("postal_code");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnName("street_name");

                    b.HasKey("AddressId");

                    b.ToTable("addresses","public");
                });
#pragma warning restore 612, 618
        }
    }
}
