using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VnRetrofitTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VnRetrofitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 180, nullable: false),
                    Price = table.Column<double>(type: "decimal(18,21)", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: false),
                    ProductTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductBrandId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductBrands_ProductBrandId",
                        column: x => x.ProductBrandId,
                        principalTable: "ProductBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Advs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VnRetrofitTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    NumParcAdv = table.Column<string>(type: "TEXT", nullable: true),
                    TypeBoitier = table.Column<string>(type: "TEXT", nullable: true),
                    Immatriculation = table.Column<string>(type: "TEXT", nullable: true),
                    Mec = table.Column<string>(type: "TEXT", nullable: true),
                    Statut = table.Column<string>(type: "TEXT", nullable: true),
                    CommentaireAdv = table.Column<string>(type: "TEXT", nullable: true),
                    Action = table.Column<string>(type: "TEXT", nullable: true),
                    OrderReceivedCompliant = table.Column<string>(type: "TEXT", nullable: true),
                    DateShipmentColumnAt = table.Column<string>(type: "TEXT", nullable: true),
                    Shipped = table.Column<string>(type: "TEXT", nullable: true),
                    Validated = table.Column<string>(type: "TEXT", nullable: true),
                    DateActivationAf3 = table.Column<string>(type: "TEXT", nullable: true),
                    InvoiceArtegy = table.Column<string>(type: "TEXT", nullable: true),
                    ClientOrderGiver = table.Column<string>(type: "TEXT", nullable: true),
                    EmailGenericPlatformAttachment = table.Column<string>(type: "TEXT", nullable: true),
                    NameCustomerDelivered = table.Column<string>(type: "TEXT", nullable: true),
                    OrderDate = table.Column<string>(type: "TEXT", nullable: true),
                    Vin = table.Column<string>(type: "TEXT", nullable: true),
                    Designation = table.Column<string>(type: "TEXT", nullable: true),
                    BrandModel = table.Column<string>(type: "TEXT", nullable: true),
                    StartDateVehicleAvailability = table.Column<string>(type: "TEXT", nullable: true),
                    EndDateVehicleAvailability = table.Column<string>(type: "TEXT", nullable: true),
                    Crc = table.Column<string>(type: "TEXT", nullable: true),
                    TypoKit = table.Column<string>(type: "TEXT", nullable: true),
                    Equipment1 = table.Column<string>(type: "TEXT", nullable: true),
                    Equipment2 = table.Column<string>(type: "TEXT", nullable: true),
                    Equipment3 = table.Column<string>(type: "TEXT", nullable: true),
                    Equipment4 = table.Column<string>(type: "TEXT", nullable: true),
                    Equipment5 = table.Column<string>(type: "TEXT", nullable: true),
                    AddressMountingNameComplement = table.Column<string>(type: "TEXT", nullable: true),
                    AddressMountingNumberOfTheStreet = table.Column<string>(type: "TEXT", nullable: true),
                    AddressMountingStreet = table.Column<string>(name: "AddressMounting_Street", type: "TEXT", nullable: true),
                    AddressMountingPostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    AddressMountingCity = table.Column<string>(type: "TEXT", nullable: true),
                    AddressMountingPhone = table.Column<string>(type: "TEXT", nullable: true),
                    ForecastDateOfBoxAssembly = table.Column<string>(type: "TEXT", nullable: true),
                    TachographMounted = table.Column<string>(type: "TEXT", nullable: true),
                    DigitallyEnabledCommunicatingTachograph = table.Column<string>(type: "TEXT", nullable: true),
                    NameOfManager = table.Column<string>(type: "TEXT", nullable: true),
                    NameOfTechnicianAdv = table.Column<string>(type: "TEXT", nullable: true),
                    AccessEcoDriving = table.Column<string>(type: "TEXT", nullable: true),
                    Accesstelematic = table.Column<string>(name: "Access_telematic", type: "TEXT", nullable: true),
                    OptionGeolocation = table.Column<string>(type: "TEXT", nullable: true),
                    OptionSocialData1 = table.Column<string>(type: "TEXT", nullable: true),
                    OptionSocialData2 = table.Column<string>(type: "TEXT", nullable: true),
                    OptionSpecific1 = table.Column<string>(type: "TEXT", nullable: true),
                    SoftwareVersion = table.Column<string>(type: "TEXT", nullable: true),
                    BoxConfiguration = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleTelematic1 = table.Column<string>(type: "TEXT", nullable: true),
                    CodeArticle1 = table.Column<string>(type: "TEXT", nullable: true),
                    PriceArticle1 = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleTelematic2 = table.Column<string>(type: "TEXT", nullable: true),
                    CodeArticle2 = table.Column<string>(type: "TEXT", nullable: true),
                    PriceArticle2 = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleTelematic3 = table.Column<string>(type: "TEXT", nullable: true),
                    CodeArticle3 = table.Column<string>(type: "TEXT", nullable: true),
                    PriceArticle3 = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleTelematic4 = table.Column<string>(type: "TEXT", nullable: true),
                    CodeArticle4 = table.Column<string>(type: "TEXT", nullable: true),
                    PriceArticle4 = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleTelematic5 = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleTelematic6 = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleTelematic7 = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleTelematic8 = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleTelematic9 = table.Column<string>(type: "TEXT", nullable: true),
                    ArticleTelematic10 = table.Column<string>(type: "TEXT", nullable: true),
                    ForRent = table.Column<string>(type: "TEXT", nullable: true),
                    InstallMonth = table.Column<string>(type: "TEXT", nullable: true),
                    BoxPosed = table.Column<string>(type: "TEXT", nullable: true),
                    DeviceId = table.Column<string>(type: "TEXT", nullable: true),
                    Sn = table.Column<string>(type: "TEXT", nullable: true),
                    NumSim = table.Column<string>(type: "TEXT", nullable: true),
                    Msisdn = table.Column<string>(type: "TEXT", nullable: true),
                    Observation = table.Column<string>(type: "TEXT", nullable: true),
                    AddressMountingName = table.Column<string>(type: "TEXT", nullable: true),
                    ChassisAddressName = table.Column<string>(type: "TEXT", nullable: true),
                    ChassisAddressNumberOfTheStreet = table.Column<string>(type: "TEXT", nullable: true),
                    ChassisAddressStreet = table.Column<string>(type: "TEXT", nullable: true),
                    ChassisAddressPostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    ChassisAddressCity = table.Column<string>(type: "TEXT", nullable: true),
                    ChassisAddressPhone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advs_VnRetrofitTypes_VnRetrofitTypeId",
                        column: x => x.VnRetrofitTypeId,
                        principalTable: "VnRetrofitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advs_VnRetrofitTypeId",
                table: "Advs",
                column: "VnRetrofitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductBrandId",
                table: "Products",
                column: "ProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advs");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "VnRetrofitTypes");

            migrationBuilder.DropTable(
                name: "ProductBrands");

            migrationBuilder.DropTable(
                name: "ProductTypes");
        }
    }
}
