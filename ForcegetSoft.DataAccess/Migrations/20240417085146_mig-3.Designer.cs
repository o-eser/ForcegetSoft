﻿// <auto-generated />
using System;
using ForcegetSoft.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForcegetSoft.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240417085146_mig-3")]
    partial class mig3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Identity.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Identity.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Incoterm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Incoterms");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Mode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Modes");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.MovementType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MovementTypes");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Offer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CityId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("IncotermId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ModeId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("MovementTypeId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PackageTypeId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("Unit1Id")
                        .HasColumnType("char(36)");

                    b.Property<double>("Unit1Quantity")
                        .HasColumnType("double");

                    b.Property<Guid>("Unit2Id")
                        .HasColumnType("char(36)");

                    b.Property<double>("Unit2Quantity")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("IncotermId");

                    b.HasIndex("ModeId");

                    b.HasIndex("MovementTypeId");

                    b.HasIndex("PackageTypeId");

                    b.HasIndex("Unit1Id");

                    b.HasIndex("Unit2Id");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.PackageType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PackageTypes");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Unit1", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Unit1s");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Unit2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Unit2s");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.City", b =>
                {
                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Offer", b =>
                {
                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.City", "City")
                        .WithMany("Offers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.Incoterm", "Incoterm")
                        .WithMany("Offers")
                        .HasForeignKey("IncotermId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.Mode", "Mode")
                        .WithMany("Offers")
                        .HasForeignKey("ModeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.MovementType", "MovementType")
                        .WithMany("Offers")
                        .HasForeignKey("MovementTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.PackageType", "PackageType")
                        .WithMany("Offers")
                        .HasForeignKey("PackageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.Unit1", "Unit1")
                        .WithMany("Offers")
                        .HasForeignKey("Unit1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.Unit2", "Unit2")
                        .WithMany("Offers")
                        .HasForeignKey("Unit2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Incoterm");

                    b.Navigation("Mode");

                    b.Navigation("MovementType");

                    b.Navigation("PackageType");

                    b.Navigation("Unit1");

                    b.Navigation("Unit2");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ForcegetSoft.Core.Entities.Concrete.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.City", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Incoterm", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Mode", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.MovementType", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.PackageType", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Unit1", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("ForcegetSoft.Core.Entities.Concrete.Unit2", b =>
                {
                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
