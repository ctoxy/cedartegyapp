﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("Core.Entities.Adv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccessEcoDriving")
                        .HasColumnType("TEXT");

                    b.Property<string>("Access_telematic")
                        .HasColumnType("TEXT");

                    b.Property<string>("Action")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressMountingCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressMountingName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressMountingNameComplement")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressMountingNumberOfTheStreet")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressMountingPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressMountingPostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressMounting_Street")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTelematic1")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTelematic10")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTelematic2")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTelematic3")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTelematic4")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTelematic5")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTelematic6")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTelematic7")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTelematic8")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleTelematic9")
                        .HasColumnType("TEXT");

                    b.Property<string>("BoxConfiguration")
                        .HasColumnType("TEXT");

                    b.Property<string>("BoxPosed")
                        .HasColumnType("TEXT");

                    b.Property<string>("BrandModel")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChassisAddressCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChassisAddressName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChassisAddressNumberOfTheStreet")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChassisAddressPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChassisAddressPostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChassisAddressStreet")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientOrderGiver")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodeArticle1")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodeArticle2")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodeArticle3")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodeArticle4")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentaireAdv")
                        .HasColumnType("TEXT");

                    b.Property<string>("Crc")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateActivationAf3")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateShipmentColumnAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Designation")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DigitallyEnabledCommunicatingTachograph")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailGenericPlatformAttachment")
                        .HasColumnType("TEXT");

                    b.Property<string>("EndDateVehicleAvailability")
                        .HasColumnType("TEXT");

                    b.Property<string>("Equipment1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Equipment2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Equipment3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Equipment4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Equipment5")
                        .HasColumnType("TEXT");

                    b.Property<string>("ForRent")
                        .HasColumnType("TEXT");

                    b.Property<string>("ForecastDateOfBoxAssembly")
                        .HasColumnType("TEXT");

                    b.Property<string>("Immatriculation")
                        .HasColumnType("TEXT");

                    b.Property<string>("InstallMonth")
                        .HasColumnType("TEXT");

                    b.Property<string>("InvoiceArtegy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mec")
                        .HasColumnType("TEXT");

                    b.Property<string>("Msisdn")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameCustomerDelivered")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameOfManager")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameOfTechnicianAdv")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumParcAdv")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumSim")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observation")
                        .HasColumnType("TEXT");

                    b.Property<string>("OptionGeolocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("OptionSocialData1")
                        .HasColumnType("TEXT");

                    b.Property<string>("OptionSocialData2")
                        .HasColumnType("TEXT");

                    b.Property<string>("OptionSpecific1")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderReceivedCompliant")
                        .HasColumnType("TEXT");

                    b.Property<string>("PriceArticle1")
                        .HasColumnType("TEXT");

                    b.Property<string>("PriceArticle2")
                        .HasColumnType("TEXT");

                    b.Property<string>("PriceArticle3")
                        .HasColumnType("TEXT");

                    b.Property<string>("PriceArticle4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Shipped")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sn")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoftwareVersion")
                        .HasColumnType("TEXT");

                    b.Property<string>("StartDateVehicleAvailability")
                        .HasColumnType("TEXT");

                    b.Property<string>("Statut")
                        .HasColumnType("TEXT");

                    b.Property<string>("TachographMounted")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeBoitier")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypoKit")
                        .HasColumnType("TEXT");

                    b.Property<string>("Validated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vin")
                        .HasColumnType("TEXT");

                    b.Property<int>("VnRetrofitTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VnRetrofitTypeId");

                    b.ToTable("Advs");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("decimal(18,21)");

                    b.Property<int>("ProductBrandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Core.Entities.ProductBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductBrands");
                });

            modelBuilder.Entity("Core.Entities.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("Core.Entities.VnRetrofitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("VnRetrofitTypes");
                });

            modelBuilder.Entity("Core.Entities.Adv", b =>
                {
                    b.HasOne("Core.Entities.VnRetrofitType", "VnRetrofitType")
                        .WithMany()
                        .HasForeignKey("VnRetrofitTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VnRetrofitType");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.HasOne("Core.Entities.ProductBrand", "ProductBrand")
                        .WithMany()
                        .HasForeignKey("ProductBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductBrand");

                    b.Navigation("ProductType");
                });
#pragma warning restore 612, 618
        }
    }
}
