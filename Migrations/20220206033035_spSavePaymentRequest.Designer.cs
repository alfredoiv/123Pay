﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _123Pay.Models;

namespace _123Pay.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220206033035_spSavePaymentRequest")]
    partial class spSavePaymentRequest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1741376b-d414-4943-807a-725fce11e2c8",
                            ConcurrencyStamp = "d5cb6caf-90cc-4a45-b16a-6a8b49e71843",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            RoleId = "1741376b-d414-4943-807a-725fce11e2c8"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("_123Pay.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d6f19490-f9a5-4cbf-a88b-f85ca68cc339",
                            Email = "alfredoiv.magpantay@yahoo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ALFREDOIV.MAGPANTAY@YAHOO.COM",
                            NormalizedUserName = "ADMINISTRATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEP9uNxR/eSnORHIO+fH9NqvyaUDbVQc8BVTb8jkHnCcdKH259qrhIyNd7IqCWOb6VQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7e42fc2f-5e4f-4fc0-a0cc-cc75ef7d0b1a",
                            TwoFactorEnabled = false,
                            UserName = "administrator"
                        });
                });

            modelBuilder.Entity("_123Pay.Models.PaymentRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("AttachmentFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Merchant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ReferenceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProcessorId");

                    b.ToTable("PaymentRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountName = "Customer 1",
                            AccountNo = "8011223301",
                            Amount = 100.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 838, DateTimeKind.Local).AddTicks(3645),
                            CustomerName = "Wan Talamera",
                            Merchant = "AT&T",
                            OtherDetails = "Other Details 1",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100001",
                            Status = "PENDING"
                        },
                        new
                        {
                            Id = 2,
                            AccountName = "Customer 2",
                            AccountNo = "8011223302",
                            Amount = 200.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7132),
                            CustomerName = "Wan Talamera",
                            Merchant = "Netflix",
                            OtherDetails = "Other Details 2",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100002",
                            Status = "PROCESSING"
                        },
                        new
                        {
                            Id = 3,
                            AccountName = "Customer 3",
                            AccountNo = "8011223303",
                            Amount = 300.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7257),
                            CustomerName = "Wan Talamera",
                            Merchant = "Amazon",
                            OtherDetails = "Other Details 3",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100003",
                            Status = "FAILED"
                        },
                        new
                        {
                            Id = 4,
                            AccountName = "Customer 4",
                            AccountNo = "8011223304",
                            Amount = 400.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7261),
                            CustomerName = "Wan Talamera",
                            Merchant = "EBay",
                            OtherDetails = "Other Details 4",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100004",
                            Status = "DONE"
                        },
                        new
                        {
                            Id = 5,
                            AccountName = "Customer 5",
                            AccountNo = "8011223305",
                            Amount = 500.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7264),
                            CustomerName = "Wan Talamera",
                            Merchant = "TELEPAY",
                            OtherDetails = "Other Details 5",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100005",
                            Status = "PENDING"
                        },
                        new
                        {
                            Id = 6,
                            AccountName = "Customer 6",
                            AccountNo = "8011223306",
                            Amount = 600.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7266),
                            CustomerName = "Wan Talamera",
                            Merchant = "AT&T",
                            OtherDetails = "Other Details 6",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100006",
                            Status = "PENDING"
                        },
                        new
                        {
                            Id = 7,
                            AccountName = "Customer 7",
                            AccountNo = "8011223307",
                            Amount = 700.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7268),
                            CustomerName = "Wan Talamera",
                            Merchant = "Netflix",
                            OtherDetails = "Other Details 7",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100007",
                            Status = "PROCESSING"
                        },
                        new
                        {
                            Id = 8,
                            AccountName = "Customer 8",
                            AccountNo = "8011223308",
                            Amount = 800.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7270),
                            CustomerName = "Wan Talamera",
                            Merchant = "Amazon",
                            OtherDetails = "Other Details 8",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100008",
                            Status = "FAILED"
                        },
                        new
                        {
                            Id = 9,
                            AccountName = "Customer 9",
                            AccountNo = "8011223309",
                            Amount = 900.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7272),
                            CustomerName = "Wan Talamera",
                            Merchant = "EBay",
                            OtherDetails = "Other Details 9",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100009",
                            Status = "DONE"
                        },
                        new
                        {
                            Id = 10,
                            AccountName = "Customer 10",
                            AccountNo = "8011223310",
                            Amount = 1000.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7274),
                            CustomerName = "Wan Talamera",
                            Merchant = "TELEPAY",
                            OtherDetails = "Other Details 10",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100010",
                            Status = "PENDING"
                        },
                        new
                        {
                            Id = 11,
                            AccountName = "Customer 11",
                            AccountNo = "8011223311",
                            Amount = 1100.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7276),
                            CustomerName = "Wan Talamera",
                            Merchant = "AT&T",
                            OtherDetails = "Other Details 11",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100011",
                            Status = "PENDING"
                        },
                        new
                        {
                            Id = 12,
                            AccountName = "Customer 12",
                            AccountNo = "8011223312",
                            Amount = 1200.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7279),
                            CustomerName = "Wan Talamera",
                            Merchant = "Netflix",
                            OtherDetails = "Other Details 12",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100012",
                            Status = "PROCESSING"
                        },
                        new
                        {
                            Id = 13,
                            AccountName = "Customer 13",
                            AccountNo = "8011223313",
                            Amount = 1300.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7281),
                            CustomerName = "Wan Talamera",
                            Merchant = "Amazon",
                            OtherDetails = "Other Details 13",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100013",
                            Status = "FAILED"
                        },
                        new
                        {
                            Id = 14,
                            AccountName = "Customer 14",
                            AccountNo = "8011223314",
                            Amount = 1400.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7283),
                            CustomerName = "Wan Talamera",
                            Merchant = "EBay",
                            OtherDetails = "Other Details 14",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100014",
                            Status = "DONE"
                        },
                        new
                        {
                            Id = 15,
                            AccountName = "Customer 15",
                            AccountNo = "8011223315",
                            Amount = 1500.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7285),
                            CustomerName = "Wan Talamera",
                            Merchant = "TELEPAY",
                            OtherDetails = "Other Details 15",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100015",
                            Status = "PENDING"
                        },
                        new
                        {
                            Id = 16,
                            AccountName = "Customer 16",
                            AccountNo = "8011223316",
                            Amount = 1600.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7287),
                            CustomerName = "Wan Talamera",
                            Merchant = "AT&T",
                            OtherDetails = "Other Details 16",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100016",
                            Status = "PENDING"
                        },
                        new
                        {
                            Id = 17,
                            AccountName = "Customer 17",
                            AccountNo = "8011223317",
                            Amount = 1700.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7290),
                            CustomerName = "Wan Talamera",
                            Merchant = "Netflix",
                            OtherDetails = "Other Details 17",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100017",
                            Status = "PROCESSING"
                        },
                        new
                        {
                            Id = 18,
                            AccountName = "Customer 18",
                            AccountNo = "8011223318",
                            Amount = 1800.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7293),
                            CustomerName = "Wan Talamera",
                            Merchant = "Amazon",
                            OtherDetails = "Other Details 18",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100018",
                            Status = "FAILED"
                        },
                        new
                        {
                            Id = 19,
                            AccountName = "Customer 19",
                            AccountNo = "8011223319",
                            Amount = 1900.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7295),
                            CustomerName = "Wan Talamera",
                            Merchant = "EBay",
                            OtherDetails = "Other Details 19",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100019",
                            Status = "DONE"
                        },
                        new
                        {
                            Id = 20,
                            AccountName = "Customer 20",
                            AccountNo = "8011223320",
                            Amount = 2000.0,
                            ClientName = "ABC Pay",
                            CreateDate = new DateTime(2022, 2, 6, 11, 30, 34, 839, DateTimeKind.Local).AddTicks(7297),
                            CustomerName = "Wan Talamera",
                            Merchant = "TELEPAY",
                            OtherDetails = "Other Details 20",
                            ProcessorId = "875b8627-6e3f-4b17-9897-236d55a0dfd7",
                            ReferenceNo = "PR2022020100020",
                            Status = "PENDING"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("_123Pay.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("_123Pay.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_123Pay.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("_123Pay.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_123Pay.Models.PaymentRequest", b =>
                {
                    b.HasOne("_123Pay.Models.ApplicationUser", "Processor")
                        .WithMany()
                        .HasForeignKey("ProcessorId");

                    b.Navigation("Processor");
                });
#pragma warning restore 612, 618
        }
    }
}