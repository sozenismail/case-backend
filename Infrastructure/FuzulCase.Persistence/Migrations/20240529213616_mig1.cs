using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FuzulCase.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FieldM2 = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estates_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "İstanbul" },
                    { 2, "İzmir" },
                    { 3, "Ankara" }
                });

            migrationBuilder.InsertData(
                table: "Estates",
                columns: new[] { "Id", "CityId", "FieldM2", "ListingDate", "Price", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { 1, 1, 100, new DateTime(2024, 5, 30, 0, 36, 16, 151, DateTimeKind.Local).AddTicks(4427), 250f, "https://pixabay.com/get/g7a73d72381e6d6d3da930b0c1998741a7101ecc8d79ddf5d0333624d6345d620ddc3595b3673f503c9d64794b1b60ef609c29a1cbecd0adbda66a6c83154cd041c2883baa8b724bfcb6254adfc8cffb7_640.jpg", "Modern ve rahat bir daire. Şehir yaşamının tüm olanaklarına yakın olan bu daire, konforlu bir yaşam sunuyor." },
                    { 2, 2, 120, new DateTime(2024, 5, 30, 0, 36, 16, 151, DateTimeKind.Local).AddTicks(4437), 200f, "https://pixabay.com/get/g0d92e7f8bdf85e6980977c270a15e1421ceb3ef450cee5a939ba8dbcecb4fbf5890f16077e363ecf3c00e5ca54febb0c7967c4ff055f31eb88ad9c3e73ee39558aa9f12163965ea84422a4edb3109bff_640.jpg", "Modern mimarinin örnekleri arasında öne çıkan villa. Yenilikçi tasarımı ve özel özellikleriyle bu villa, şıklık ve lüksü bir araya getiriyor." },
                    { 3, 3, 90, new DateTime(2024, 5, 30, 0, 36, 16, 151, DateTimeKind.Local).AddTicks(4438), 150f, "https://pixabay.com/get/g8dd6911882900526296d4aa50f452a8426bedb0864e589618d9a08eefa1e71e722b10cb8a48c9249617e4573ab3cd20ed29189db34011acf0a78af0d593d3866d61c5ee288e94390648642f5c265e9a7_640.jpg", "Şehre yakın bir tatil köyünde villa. Plajlara yakın olan bu villa, deniz ve güneşin keyfini çıkarmak isteyenlere hitap ediyor." },
                    { 4, 1, 200, new DateTime(2024, 5, 30, 0, 36, 16, 151, DateTimeKind.Local).AddTicks(4440), 450f, "https://pixabay.com/get/g16573450479b2cf9157f4b03b6c2e1bcd6c2dbee098d005062fb74fd6b5cc1601e4e98023f944420e06a2743c95b60715223b57e8161179a8b4ed5c7d3561e87a97a59b9161113689b83bc6389775e5c_640.jpg", "Sessiz ve huzurlu dağ evi. Doğanın kucakladığı bu ev, doğal güzellikler içinde sakin bir yaşam sunuyor." },
                    { 5, 2, 300, new DateTime(2024, 5, 30, 0, 36, 16, 151, DateTimeKind.Local).AddTicks(4441), 550f, "https://pixabay.com/get/g954410a421b64c1e1d4e3f553f6362fe4180dec5e95faf37d92a9cbb628b0b08b13e862b635737115d7a67f3601e20151d0f02c97f8bdf47f3ec5cb78ed331284faf2f257a99b7facb8a8fc00953ec34_640.jpg", "Sosyal tesislere sahip site içi daire. Havuz, spor alanları ve daha fazlasıyla bu site, sosyal bir yaşam sunuyor." },
                    { 6, 1, 220, new DateTime(2024, 5, 30, 0, 36, 16, 151, DateTimeKind.Local).AddTicks(4442), 210f, "https://pixabay.com/get/g195f346b42fdd79c54d1e6e74d8027c36d24f940076d9d0a4b9ed01a0c4c81a6ef34d8a04dc67827ae08db2542915910711cc2a72e41ecb21ec7b640a2ba31e37b8b3f22514f3b48497bb1367d091190_640.jpg", "Sahile yakın modern daire. Plajlara yakın olan bu daire, deniz severlere hitap ediyor." },
                    { 7, 3, 120, new DateTime(2024, 5, 30, 0, 36, 16, 151, DateTimeKind.Local).AddTicks(4444), 150f, "https://pixabay.com/get/g022ffdbdd0238b95062df3c4f630e5e0e96eff610545c79db2ce54127031e93368ed73bcf8792d601208aee67eb69168c836edb1a127dd6ad1c44110cf771e4091d1abb285f39813c8bf0d9c9734b981_640.jpg", "Bahçeli taş ev. Geleneksel mimariyle tasarlanan bu ev, doğal ve sıcak bir atmosfer sunuyor." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estates_CityId",
                table: "Estates",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estates");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
