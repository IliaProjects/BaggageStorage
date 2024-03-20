﻿// <auto-generated />
using BaggageStorage.Data;
using BaggageStorage.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BaggageStorage.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180922063516_AlterCashOperationsArchive")]
    partial class AlterCashOperationsArchive
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("BaggageStorage.Data.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias")
                        .IsRequired();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CustomerId")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.HasIndex("UserId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerId")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.BaggageMoving", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<int>("AmountOfDays");

                    b.Property<int>("AmountOfPlaces");

                    b.Property<string>("StorageId")
                        .IsRequired();

                    b.Property<string>("ClientId")
                        .IsRequired();

                    b.Property<DateTime>("DateIn");

                    b.Property<DateTime>("DateOut");

                    b.Property<string>("StoragePlaceId")
                        .IsRequired();

                    b.Property<string>("UserInId")
                        .IsRequired();

                    b.Property<string>("UserOutId");

                    b.HasKey("Id");

                    b.HasIndex("StorageId");

                    b.HasIndex("ClientId");

                    b.HasIndex("StoragePlaceId");

                    b.HasIndex("UserInId");

                    b.HasIndex("UserOutId");

                    b.ToTable("BaggageMovings");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.BaggageMovingArchive", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<int>("AmountOfDays");

                    b.Property<int>("AmountOfPlaces");

                    b.Property<string>("StorageId")
                        .IsRequired();

                    b.Property<string>("ClientId")
                        .IsRequired();

                    b.Property<DateTime>("DateIn");

                    b.Property<DateTime>("DateOut");

                    b.Property<string>("StoragePlaceId")
                        .IsRequired();

                    b.Property<string>("UserDeletedId");

                    b.Property<string>("UserInId")
                        .IsRequired();

                    b.Property<string>("UserOutId");

                    b.HasKey("Id");

                    b.HasIndex("StorageId");

                    b.ToTable("BaggageMovingArchives");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.BaggageRegister", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AmountOfDays")
                        .IsRequired();

                    b.Property<string>("BaggageMovingId");

                    b.Property<string>("StorageId");

                    b.Property<string>("ClientId")
                        .IsRequired();

                    b.Property<DateTime>("DateIn");

                    b.HasKey("Id");

                    b.HasIndex("BaggageMovingId");

                    b.HasIndex("StorageId");

                    b.HasIndex("ClientId");

                    b.ToTable("BaggageRegisters");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.BaggageStorage", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ShortName");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.CashOperation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("BaggageMovingId");

                    b.Property<string>("StorageId")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<int>("Operation");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("BaggageMovingId");

                    b.HasIndex("StorageId");

                    b.HasIndex("UserId");

                    b.ToTable("CashOperations");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.CashOperationArchive", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("BaggageMovingId");

                    b.Property<string>("StorageId")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<int>("Operation");

                    b.Property<string>("UserDeletedId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CashOperationArchives");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.Client", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .HasMaxLength(254);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ParentId")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.MainMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Icon");

                    b.Property<bool>("IsActive");

                    b.Property<string>("JsFunction");

                    b.Property<string>("Location");

                    b.Property<int>("OrderId");

                    b.Property<int>("ParentId");

                    b.Property<string>("PermissionEnumText");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("TextEn")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("TextRo")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("MainMenu");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.Operation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EnumName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("OperationTypeId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("OperationTypeId");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.OperationType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("OperationTypes");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.Permission", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OperationId")
                        .IsRequired();

                    b.Property<bool>("Permitted");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("OperationId");

                    b.HasIndex("RoleId", "OperationId")
                        .IsUnique();

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.StoragePlace", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StorageId")
                        .IsRequired();

                    b.Property<string>("Place")
                        .IsRequired();

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.HasIndex("StorageId");

                    b.ToTable("StoragePlaces");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.UserConnection", b =>
                {
                    b.Property<string>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<bool>("IsOnline");

                    b.Property<bool>("IsRemember");

                    b.Property<string>("LastRequestAction")
                        .HasMaxLength(50);

                    b.Property<string>("LastRequestController")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LastRequestDate");

                    b.Property<string>("LastRequestPostParams");

                    b.Property<string>("LastRequestRawUrl")
                        .HasMaxLength(1024);

                    b.Property<string>("UserAgent")
                        .HasMaxLength(1024);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<string>("UserIp")
                        .HasMaxLength(39);

                    b.HasKey("SessionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserConnection");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.WorkPlace", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AmountOfCopies");

                    b.Property<string>("StorageId");

                    b.Property<string>("CustomerId")
                        .IsRequired();

                    b.Property<string>("IpAdress")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Port");

                    b.Property<string>("PrintName")
                        .IsRequired();

                    b.Property<string>("TemplateName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("StorageId");

                    b.HasIndex("CustomerId");

                    b.ToTable("WorkPlaces");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.ApplicationRole", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.Customer", "Customer")
                        .WithMany("Roles")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaggageStorage.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.Customer", "Customer")
                        .WithMany("Users")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.BaggageMoving", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.BaggageStorage", "BaggageStorage")
                        .WithMany("BaggageMovings")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaggageStorage.Data.Models.Client", "Client")
                        .WithMany("BaggageMovings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaggageStorage.Data.Models.StoragePlace", "StoragePlace")
                        .WithMany("BaggageMovings")
                        .HasForeignKey("StoragePlaceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaggageStorage.Data.Models.ApplicationUser", "UserIn")
                        .WithMany("UsersIn")
                        .HasForeignKey("UserInId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaggageStorage.Data.Models.ApplicationUser", "UserOut")
                        .WithMany("UsersOut")
                        .HasForeignKey("UserOutId");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.BaggageMovingArchive", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.BaggageStorage")
                        .WithMany("BaggageMovingArchives")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.BaggageRegister", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.BaggageMoving", "BaggageMoving")
                        .WithMany("BaggageRegisters")
                        .HasForeignKey("BaggageMovingId");

                    b.HasOne("BaggageStorage.Data.Models.BaggageStorage", "BaggageStorage")
                        .WithMany("BaggageRegisters")
                        .HasForeignKey("StorageId");

                    b.HasOne("BaggageStorage.Data.Models.Client", "Client")
                        .WithMany("BaggageRegisters")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.BaggageStorage", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.Customer", "Customer")
                        .WithMany("Storages")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.CashOperation", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.BaggageMoving", "BaggageMoving")
                        .WithMany("CashOperations")
                        .HasForeignKey("BaggageMovingId");

                    b.HasOne("BaggageStorage.Data.Models.BaggageStorage", "BaggageStorage")
                        .WithMany("CashOperations")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaggageStorage.Data.Models.ApplicationUser", "User")
                        .WithMany("CashOperations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.Operation", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.OperationType", "OperationType")
                        .WithMany("Operations")
                        .HasForeignKey("OperationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.Permission", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.Operation", "Operation")
                        .WithMany("Permissions")
                        .HasForeignKey("OperationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaggageStorage.Data.Models.ApplicationRole", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.StoragePlace", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.BaggageStorage", "BaggageStorage")
                        .WithMany("StoragePlaces")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.UserConnection", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BaggageStorage.Data.Models.WorkPlace", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.BaggageStorage", "BaggageStorage")
                        .WithMany("WorkPlaces")
                        .HasForeignKey("StorageId");

                    b.HasOne("BaggageStorage.Data.Models.Customer", "Customer")
                        .WithMany("WorkPlaces")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BaggageStorage.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BaggageStorage.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}