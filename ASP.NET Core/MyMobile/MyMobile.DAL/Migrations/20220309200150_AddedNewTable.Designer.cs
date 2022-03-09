﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyMobile.DAL.Data;

#nullable disable

namespace MyMobile.DAL.Migrations
{
    [DbContext(typeof(MyMobileContext))]
    [Migration("20220309200150_AddedNewTable")]
    partial class AddedNewTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("ConditionId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DefaultPriceBgn")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("EngineId")
                        .HasColumnType("int");

                    b.Property<int>("EurostandardId")
                        .HasColumnType("int");

                    b.Property<int>("GearboxId")
                        .HasColumnType("int");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<int>("ManufactureMonth")
                        .HasColumnType("int");

                    b.Property<int>("ManufactureYear")
                        .HasColumnType("int");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("Modification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.Property<decimal>("UserPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VehicleCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ConditionId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("EngineId");

                    b.HasIndex("EurostandardId");

                    b.HasIndex("GearboxId");

                    b.HasIndex("MakeId");

                    b.HasIndex("ModelId");

                    b.HasIndex("RegionId");

                    b.HasIndex("TownId");

                    b.HasIndex("VehicleCategoryId");

                    b.ToTable("CarAds");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAdArgs.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Aвтомобили и джипове"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Бусове"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Камиони"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAdArgs.Condition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conditions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Употребяван"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Нов"
                        },
                        new
                        {
                            Id = 3,
                            Type = "За части"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAdArgs.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("CourseToDefault")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseToDefault = 1m,
                            Name = "BGN"
                        },
                        new
                        {
                            Id = 2,
                            CourseToDefault = 1.95m,
                            Name = "EUR"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAdArgs.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Пловдив"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAdArgs.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Towns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Асеновград",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Садово",
                            RegionId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Карлово",
                            RegionId = 1
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.CarAdComfort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarAdId")
                        .HasColumnType("int");

                    b.Property<int>("ComfortId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarAdId");

                    b.HasIndex("ComfortId");

                    b.ToTable("CarAdComforts");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.CarAdInterior", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarAdId")
                        .HasColumnType("int");

                    b.Property<int>("InteriorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarAdId");

                    b.HasIndex("InteriorId");

                    b.ToTable("CarAdInteriors");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.CarAdSecurity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarAdId")
                        .HasColumnType("int");

                    b.Property<int>("SecurityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarAdId");

                    b.HasIndex("SecurityId");

                    b.ToTable("CarAdSecurities");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Металик"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Черен"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Син"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Сив"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Бордо"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Comfort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Comforts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Навигация"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Темпомат"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Стерео уредба"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Подгряване на седалките"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Климатик"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Климатроник"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Engines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Бензинов"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Дизелов"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Електрически"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Хибриден"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Eurostandard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Eurostandards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Euro 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Euro 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Euro 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Euro 4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Euro 5"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Euro 6"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Gearbox", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gearboxes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Ръчна"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Автоматична"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Полуавтоматична"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Interior", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interiors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Кожен салон"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Велурен салон"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Десен волан"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Makes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mercedes-Benz"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Opel"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Jeep"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Nissan"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MakeId = 1,
                            Name = "530"
                        },
                        new
                        {
                            Id = 2,
                            MakeId = 1,
                            Name = "528"
                        },
                        new
                        {
                            Id = 3,
                            MakeId = 2,
                            Name = "E 320"
                        },
                        new
                        {
                            Id = 4,
                            MakeId = 2,
                            Name = "C 180"
                        },
                        new
                        {
                            Id = 5,
                            MakeId = 3,
                            Name = "Vectra"
                        },
                        new
                        {
                            Id = 6,
                            MakeId = 4,
                            Name = "Grand Cherokee"
                        },
                        new
                        {
                            Id = 7,
                            MakeId = 5,
                            Name = "Patrol"
                        },
                        new
                        {
                            Id = 8,
                            MakeId = 5,
                            Name = "Terano"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Security", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Securities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "GPS система за проследяване"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Автоматичен контрол на стабилността"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Антиблокираща система"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Въздушни възглавници"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Парктроник"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Система за защита от пробуксуване"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.VehicleCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Седан"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Комби"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Стреч лимузина"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Джип"
                        });
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAd", b =>
                {
                    b.HasOne("MyMobile.DAL.Models.CarAd.CarAdArgs.Category", "Category")
                        .WithMany("CarAds")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarArgs.Color", "Color")
                        .WithMany("CarAds")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarAdArgs.Condition", "Condition")
                        .WithMany("CarAds")
                        .HasForeignKey("ConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarAdArgs.Currency", "Currency")
                        .WithMany("CarAds")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarArgs.Engine", "Engine")
                        .WithMany("CarAds")
                        .HasForeignKey("EngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarArgs.Eurostandard", "Eurostandard")
                        .WithMany("CarAds")
                        .HasForeignKey("EurostandardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarArgs.Gearbox", "Gearbox")
                        .WithMany("CarAds")
                        .HasForeignKey("GearboxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarArgs.Make", "Make")
                        .WithMany("CarAds")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarArgs.Model", "Model")
                        .WithMany("CarAds")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarAdArgs.Region", "Region")
                        .WithMany("CarAds")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarAdArgs.Town", "Town")
                        .WithMany("CarAds")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarArgs.VehicleCategory", "VehicleCategory")
                        .WithMany("CarAds")
                        .HasForeignKey("VehicleCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Condition");

                    b.Navigation("Currency");

                    b.Navigation("Engine");

                    b.Navigation("Eurostandard");

                    b.Navigation("Gearbox");

                    b.Navigation("Make");

                    b.Navigation("Model");

                    b.Navigation("Region");

                    b.Navigation("Town");

                    b.Navigation("VehicleCategory");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAdArgs.Town", b =>
                {
                    b.HasOne("MyMobile.DAL.Models.CarAd.CarAdArgs.Region", "Region")
                        .WithMany("Towns")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.CarAdComfort", b =>
                {
                    b.HasOne("MyMobile.DAL.Models.CarAd.CarAd", "CarAd")
                        .WithMany("CarAdComforts")
                        .HasForeignKey("CarAdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarArgs.Comfort", "Comfort")
                        .WithMany("CarAdComforts")
                        .HasForeignKey("ComfortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarAd");

                    b.Navigation("Comfort");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.CarAdInterior", b =>
                {
                    b.HasOne("MyMobile.DAL.Models.CarAd.CarAd", "CarAd")
                        .WithMany("CarAdInteriors")
                        .HasForeignKey("CarAdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarArgs.Interior", "Interior")
                        .WithMany("CarAdInteriors")
                        .HasForeignKey("InteriorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarAd");

                    b.Navigation("Interior");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.CarAdSecurity", b =>
                {
                    b.HasOne("MyMobile.DAL.Models.CarAd.CarAd", "CarAd")
                        .WithMany("CarAdSecurities")
                        .HasForeignKey("CarAdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMobile.DAL.Models.CarAd.CarArgs.Security", "Security")
                        .WithMany("CarAdSecurities")
                        .HasForeignKey("SecurityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarAd");

                    b.Navigation("Security");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Model", b =>
                {
                    b.HasOne("MyMobile.DAL.Models.CarAd.CarArgs.Make", "Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Make");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAd", b =>
                {
                    b.Navigation("CarAdComforts");

                    b.Navigation("CarAdInteriors");

                    b.Navigation("CarAdSecurities");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAdArgs.Category", b =>
                {
                    b.Navigation("CarAds");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAdArgs.Condition", b =>
                {
                    b.Navigation("CarAds");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAdArgs.Currency", b =>
                {
                    b.Navigation("CarAds");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAdArgs.Region", b =>
                {
                    b.Navigation("CarAds");

                    b.Navigation("Towns");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarAdArgs.Town", b =>
                {
                    b.Navigation("CarAds");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Color", b =>
                {
                    b.Navigation("CarAds");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Comfort", b =>
                {
                    b.Navigation("CarAdComforts");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Engine", b =>
                {
                    b.Navigation("CarAds");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Eurostandard", b =>
                {
                    b.Navigation("CarAds");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Gearbox", b =>
                {
                    b.Navigation("CarAds");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Interior", b =>
                {
                    b.Navigation("CarAdInteriors");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Make", b =>
                {
                    b.Navigation("CarAds");

                    b.Navigation("Models");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Model", b =>
                {
                    b.Navigation("CarAds");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.Security", b =>
                {
                    b.Navigation("CarAdSecurities");
                });

            modelBuilder.Entity("MyMobile.DAL.Models.CarAd.CarArgs.VehicleCategory", b =>
                {
                    b.Navigation("CarAds");
                });
#pragma warning restore 612, 618
        }
    }
}
