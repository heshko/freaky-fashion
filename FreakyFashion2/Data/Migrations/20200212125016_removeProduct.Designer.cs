﻿// <auto-generated />
using System;
using FreakyFashion2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreakyFashion2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200212125016_removeProduct")]
    partial class removeProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FreakyFashion2.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Trouthers"
                        },
                        new
                        {
                            Id = 2,
                            Name = "T-Shirts"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dresses"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sale"
                        });
                });

            modelBuilder.Entity("FreakyFashion2.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ProductNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Material: 98% bomull, 2% elastan",
                            ImageUrl = "https://mosaic03.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/QK/12/BEJ22G02Q-K12@14.jpg",
                            Name = "Chinos",
                            Price = 300f,
                            ProductNumber = "02343211234"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Material: Material: 100% polyester",
                            ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/M9/12/2G/0F/3K/11/M9122G0F3-K11@14.jpg",
                            Name = "TRAIN LOGO PANT",
                            Price = 400f,
                            ProductNumber = "02343211234"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Material: Best Byxor",
                            ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/PK/11/BEJ22G02P-K11@6.2.jpg",
                            Name = "HYBRID PANT",
                            Price = 400f,
                            ProductNumber = "01231234"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Material: 90% polyester, 10% elastan",
                            ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/OQ/11/BEJ22G02O-Q11@2.1.jpg",
                            Name = "FLEX WOVEN",
                            Price = 200f,
                            ProductNumber = "032213"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Material: 79% bomull, 21% polyester",
                            ImageUrl = "https://mosaic03.ztat.net/vgs/media/catalog-sm/PO/22/2O/03/FC/14/PO222O03F-C14@3.jpg",
                            Name = "TAPE PANTS",
                            Price = 700f,
                            ProductNumber = "032213"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/OK/12/BEJ22G02O-K12@10.1.jpg",
                            Name = "Tygbyxor",
                            Price = 400f,
                            ProductNumber = "0231241"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Material: 84% polyester, 15% viskos, 1% elastan",
                            ImageUrl = "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/oqd1pzehuh6pqdsjtoy4/sportswear-tech-fleece-trousers-vWH3lg.jpg",
                            Name = "Tygbyxor-b",
                            Price = 200f,
                            ProductNumber = "023990"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Material: 97% bomull, 3% elastanr",
                            ImageUrl = "https://mosaic03.ztat.net/vgs/media/catalog-sm/BE/J2/2G/02/QQ/11/BEJ22G02Q-Q11@10.1.jpg",
                            Name = "Tygbyxor",
                            Price = 200f,
                            ProductNumber = "02329980"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://img01.ztat.net/article/DI/62/2D/00/A8/02/DI622D00A-802@16.jpg?imwidth=300",
                            Name = "Piké",
                            Price = 700f,
                            ProductNumber = "10098"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://img01.ztat.net/article/AD/12/2O/0A/OQ/11/AD122O0AO-Q11@13.jpg?imwidth=300",
                            Name = "FLORAL PANEL - Piké",
                            Price = 100f,
                            ProductNumber = "10987712"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://img01.ztat.net/article/C1/42/2O/03/PQ/11/C1422O03P-Q11@8.jpg?imwidth=300",
                            Name = "CHECK - Piké",
                            Price = 190f,
                            ProductNumber = "10976152"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Material: 60% bomull, 40% polyester",
                            ImageUrl = "https://img01.ztat.net/article/DI/62/2O/02/DC/11/DI622O02D-C11@9.jpg?imwidth=300",
                            Name = "Sweatshirt",
                            Price = 200f,
                            ProductNumber = "1231320091"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://images.www.fendi.com/images/h07/h2b/8971945836574/FS7255A5XSF0GME_01_medium",
                            Name = "Piké",
                            Price = 400f,
                            ProductNumber = "12313212131"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://img01.ztat.net/article/LE/22/2O/05/EM/11/LE222O05E-M11@6.jpg?imwidth=300",
                            Name = "BASIC 2 PACK - Piké",
                            Price = 700f,
                            ProductNumber = "189912002"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Material: 100% bomull",
                            ImageUrl = "https://img01.ztat.net/article/AD/12/2O/0L/4I/11/AD122O0L4-I11@34.jpg?imwidth=300",
                            Name = "GEO ALL - Piké",
                            Price = 200f,
                            ProductNumber = "12313299901"
                        },
                        new
                        {
                            Id = 16,
                            Description = "MATERIAL & SKÖTSEL",
                            ImageUrl = "https://img01.ztat.net/article/TH/34/2D/00/TC/11/TH342D00T-C11@17.jpg?imwidth=300",
                            Name = "CAMBRIDGE - Piké",
                            Price = 300f,
                            ProductNumber = "112312"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Material: 100% viskos",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/2714/9310/products/Unique_Vintage_1950s_Black_Embroidered_Red_Rose_Baltimore_Swing_Dress_1024x1024.jpg?v=1571711475",
                            Name = "TAMAYO DRESS",
                            Price = 900f,
                            ProductNumber = "2221312131321"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Material: 100% viskos",
                            ImageUrl = "https://photo.venus.com/im/18062700.jpg?preset=product",
                            Name = "MNIA DRESS",
                            Price = 200f,
                            ProductNumber = "2231321"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Material: 100% viskos",
                            ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/WG/02/1C/0B/PM/11/WG021C0BP-M11@18.jpg",
                            Name = "GILLEA - Skjortklänning",
                            Price = 1200f,
                            ProductNumber = "223000989"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Material: 100% polyester",
                            ImageUrl = "https://mosaic03.ztat.net/vgs/media/catalog-sm/WG/02/1C/0E/6G/11/WG021C0E6-G11@6.jpg",
                            Name = "VALENTINA DRESS - Skjortklänning",
                            Price = 400f,
                            ProductNumber = "2231099212"
                        },
                        new
                        {
                            Id = 21,
                            Description = "Material: 100% polyester",
                            ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/ZX/12/1C/00/2Q/11/ZX121C002-Q11@11.jpg",
                            Name = "AMARIS LONG KIMONO",
                            Price = 2000f,
                            ProductNumber = "22099812"
                        },
                        new
                        {
                            Id = 22,
                            Description = "Material: 100% polyester",
                            ImageUrl = "https://mosaic03.ztat.net/vgs/media/catalog-sm/BE/J2/1C/09/CQ/11/BEJ21C09C-Q11@15.jpg",
                            Name = "CETO DRAWSTRING",
                            Price = 300f,
                            ProductNumber = "209990"
                        },
                        new
                        {
                            Id = 23,
                            Description = "Material: 100% viskos",
                            ImageUrl = "https://mosaic04.ztat.net/vgs/media/catalog-sm/Z1/72/1C/07/GK/11/Z1721C07G-K11@3.jpg",
                            Name = "NINGBOX - Skjortklänning",
                            Price = 400f,
                            ProductNumber = "29761125"
                        },
                        new
                        {
                            Id = 24,
                            Description = "Material: 100% viskos",
                            ImageUrl = "https://mosaic03.ztat.net/vgs/media/outfit-image-mhq/53d1874b9e594f3bb8f8b9d7096f9f45/19b5700ddf7c4f94998ea439a9bd8868.jpeg?imwidth=600",
                            Name = "PCNICOLETTA DRESS - Skjortklänning",
                            Price = 1500f,
                            ProductNumber = "200918"
                        });
                });

            modelBuilder.Entity("FreakyFashion2.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            ProductId = 8
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            ProductId = 9
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            ProductId = 10
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            ProductId = 11
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            ProductId = 12
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            ProductId = 13
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            ProductId = 14
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            ProductId = 15
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            ProductId = 16
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            ProductId = 17
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            ProductId = 18
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 3,
                            ProductId = 19
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            ProductId = 20
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 3,
                            ProductId = 21
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 3,
                            ProductId = 22
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 3,
                            ProductId = 23
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 3,
                            ProductId = 24
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 4,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 4,
                            ProductId = 12
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 4,
                            ProductId = 15
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 4,
                            ProductId = 24
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 4,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 4,
                            ProductId = 22
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 4,
                            ProductId = 13
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 4,
                            ProductId = 15
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FreakyFashion2.Models.ProductCategory", b =>
                {
                    b.HasOne("FreakyFashion2.Models.Category", "Category")
                        .WithMany("ProductCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreakyFashion2.Models.Product", "Product")
                        .WithMany("ProductCategory")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
