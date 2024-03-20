﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using BaggageStorage.DataLog;
using BaggageStorage.DataLog.Models;
using System;
using Z.EntityFramework.Plus;

namespace BaggageStorage.DataLog.Migrations
{
    [DbContext(typeof(LogDbContext))]
    partial class LogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("BaggageStorage.DataLog.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Controller")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("Date");

                    b.Property<int>("EventType");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("Method");

                    b.Property<string>("RawUrl")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<string>("RequestPostParams");

                    b.Property<string>("UserAgent")
                        .HasMaxLength(1024);

                    b.Property<string>("UserId");

                    b.Property<string>("UserIp")
                        .HasMaxLength(39);

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Z.EntityFramework.Plus.AuditEntry", b =>
                {
                    b.Property<int>("AuditEntryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("EntitySetName")
                        .HasMaxLength(255);

                    b.Property<string>("EntityTypeName")
                        .HasMaxLength(255);

                    b.Property<int>("State");

                    b.Property<string>("StateName")
                        .HasMaxLength(255);

                    b.HasKey("AuditEntryID");

                    b.ToTable("AuditEntry");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AuditEntry");
                });

            modelBuilder.Entity("Z.EntityFramework.Plus.AuditEntryProperty", b =>
                {
                    b.Property<int>("AuditEntryPropertyID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuditEntryID");

                    b.Property<string>("NewValueFormatted")
                        .HasColumnName("NewValue");

                    b.Property<string>("OldValueFormatted")
                        .HasColumnName("OldValue");

                    b.Property<string>("PropertyName")
                        .HasMaxLength(255);

                    b.Property<string>("RelationName")
                        .HasMaxLength(255);

                    b.HasKey("AuditEntryPropertyID");

                    b.HasIndex("AuditEntryID");

                    b.ToTable("AuditEntryProperties");
                });

            modelBuilder.Entity("BaggageStorage.DataLog.Models.CustomAuditEntry", b =>
                {
                    b.HasBaseType("Z.EntityFramework.Plus.AuditEntry");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(15);

                    b.Property<string>("UserAgent")
                        .HasMaxLength(255);

                    b.ToTable("AuditEntries");

                    b.HasDiscriminator().HasValue("CustomAuditEntry");
                });

            modelBuilder.Entity("Z.EntityFramework.Plus.AuditEntryProperty", b =>
                {
                    b.HasOne("Z.EntityFramework.Plus.AuditEntry", "Parent")
                        .WithMany("Properties")
                        .HasForeignKey("AuditEntryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}