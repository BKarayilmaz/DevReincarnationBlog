using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevReincarnationBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewInitialWithDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("00b6575f-5640-4080-9dd3-7fe43b04f1e1"), "Admin Test", new DateTime(2023, 6, 11, 17, 9, 43, 97, DateTimeKind.Local).AddTicks(9707), null, null, false, null, null, "Yapay Zeka" },
                    { new Guid("044b2971-89a5-4596-8da3-87bca0c4a7b2"), "Admin Test", new DateTime(2023, 6, 11, 17, 9, 43, 97, DateTimeKind.Local).AddTicks(9710), null, null, false, null, null, "VR ve Ar Teknolojileri" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("558c3495-e0bb-4824-bcbf-a48b08263cfe"), "Admin Test", new DateTime(2023, 6, 11, 17, 9, 43, 97, DateTimeKind.Local).AddTicks(9773), null, null, "images/testimage2", "jpg", false, null, null },
                    { new Guid("b8a7bb31-7655-47eb-9d59-72c0be1c8c06"), "Admin Test", new DateTime(2023, 6, 11, 17, 9, 43, 97, DateTimeKind.Local).AddTicks(9770), null, null, "images/testimage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("234e4eb0-deef-45aa-9fe9-6f2b5c19abf0"), new Guid("044b2971-89a5-4596-8da3-87bca0c4a7b2"), "Sanal Gerçeklik (VR) teknolojisi, günümüzdeki en heyecan verici yeniliklerden biridir. VR gözlükleri, kullanıcıları gerçek dünyadan koparıp sanal bir ortama taşıyarak tamamen yeni bir deneyim sunmaktadır. Bu inanılmaz teknoloji, eğlence sektöründen eğitim ve sağlık gibi birçok alanda çığır açmaktadır. VR gözlüklerinin geleceği ise oldukça parlak ve hayal gücümüzün sınırlarını zorlayacak.\r\n\r\nİlk olarak, eğlence sektöründe VR gözlükleri müthiş bir etki yaratmaktadır. Oyun endüstrisi, VR teknolojisi sayesinde kullanıcıları oyunların içine doğrudan yerleştirebilmekte ve daha önce hiç yaşanmamış deneyimler sunmaktadır. Gerçekçi grafikler, üç boyutlu ses efektleri ve hareket kontrolü gibi özellikler, oyuncuların oyun dünyasında tam anlamıyla kaybolmalarını sağlamaktadır. Ayrıca, VR gözlükleri sinema sektöründe de büyük bir potansiyele sahiptir. Sanal sinema deneyimi, seyircilere filmleri daha etkileyici bir şekilde deneyimleme imkanı sunacak ve izleyiciyi olayların tam merkezine yerleştirecektir.\r\n\r\nEğitim alanında VR gözlükleri, öğrenmeyi daha etkili ve eğlenceli hale getirecektir. Sanal sınıflar, öğrencilerin coğrafyayı keşfetmesine, tarihî olayları yeniden yaşamasına veya karmaşık kavramları görsel olarak anlamasına olanak tanıyacaktır. Bu, öğrencilerin daha derin bir anlayış geliştirmelerini ve daha aktif bir şekilde öğrenmelerini sağlayacaktır.\r\n\r\nSağlık alanında VR, terapi ve rehabilitasyon süreçlerinde büyük bir rol oynamaktadır. Örneğin, sanal gerçeklik tedavisi, korku veya anksiyete gibi psikolojik sorunlarla mücadelede etkili bir yöntemdir. Ayrıca, cerrahi eğitimlerde ve acil durum senaryolarında pratik yapma imkanı sunarak sağlık çalışanlarının becerilerini geliştirmelerine yardımcı olmaktadır.\r\n\r\nVR gözlükleriyle ilgili en heyecan verici şey ise potansiyelidir. Gelecekte, VR gözlüklerinin daha hafif, daha ergonomik ve daha gerçekçi hale gelmesi beklenmektedir. Ayrıca, artırılmış gerçeklik (AR) ve sanal gerçeklik (VR) teknolojilerinin birleştirilmesiyle daha etkileyici ve etkileşimli deneyimlerin ortaya çıkması muhtemeldir.\r\n\r\nSanal Gerçeklik Gözlükleri, gelecekte hayatımızı büyük ölçüde etkileyecek bir teknolojidir. Eğlence, eğitim, sağlık ve daha birçok alanda kullanılmaya devam edecek olan VR gözlükleri, insan deneyimini tamamen dönüştürerek bizi yeni dünyalara taşıyacaktır.", "Admin Test", new DateTime(2023, 6, 11, 17, 9, 43, 97, DateTimeKind.Local).AddTicks(9558), null, null, new Guid("558c3495-e0bb-4824-bcbf-a48b08263cfe"), false, null, null, "Sanal Gerçeklik Gözlükleri: Hayal Dünyasına Kapı Aralanıyor", 38 },
                    { new Guid("d727af20-293b-4f6d-b03b-c478db9dd615"), new Guid("00b6575f-5640-4080-9dd3-7fe43b04f1e1"), "Yapay Zeka (YZ) teknolojisi, son yıllarda hızla gelişerek hayatımızın birçok alanında kendine yer edinmiştir. Ancak, YZ'nin geleceği konusunda daha heyecan verici yenilikler beklemekteyiz. Gelecekteki potansiyeli nedeniyle YZ, insanlığın önünde inanılmaz fırsatlar sunacak ve dünyayı baştan aşağı değiştirecektir.\r\n\r\nİlk olarak, YZ'nin sağlık alanında devrim yaratacağına şüphe yok. YZ destekli tanı sistemleri, tıbbi verilerin analizi ve hastalıkların erken teşhisi gibi alanlarda önemli bir rol oynayacaktır. Bu, hastaların daha iyi tedavi edilmesini ve hastalıkların önlenmesini sağlayarak sağlık hizmetlerini iyileştirecektir. YZ, karmaşık cerrahi işlemlerde de cerrahların yanında yer alacak ve bu alanda daha güvenli ve etkili müdahalelerin gerçekleştirilmesine yardımcı olacaktır.\r\n\r\nYZ'nin başka bir alanı ise ulaşım olacaktır. Otonom araçlar, trafik akışını optimize ederek trafik kazalarını ve gecikmeleri azaltacak. Ayrıca, YZ destekli lojistik sistemleri, mal taşımacılığında daha etkin ve verimli bir şekilde çalışacak ve tedarik zincirinin iyileştirilmesine katkı sağlayacaktır.\r\n\r\nEğitim sektöründe de YZ, büyük bir devrim yapacak. Öğrencilere özel eğitim programları sunarak bireyselleştirilmiş öğrenme deneyimleri sunacak ve eğitimde eşitsizlikleri azaltacak. Ayrıca, öğretmenlerin iş yükünü hafifletecek ve onlara daha fazla öğrenciye odaklanma imkanı verecektir. YZ destekli sanal gerçeklik ve artırılmış gerçeklik uygulamalarıyla da öğrenme deneyimleri daha etkileyici hale gelecektir.\r\n\r\nSon olarak, YZ'nin iş dünyasına etkisi de dikkate değerdir. YZ destekli otomasyon sistemleri, üretim süreçlerini optimize edecek ve verimliliği artıracaktır. Ayrıca, YZ'nin doğal dil işleme ve müşteri hizmetleri alanındaki ilerlemeleri, müşteri deneyimini daha kişiselleştirilmiş hale getirecektir.", "Admin Test", new DateTime(2023, 6, 11, 17, 9, 43, 97, DateTimeKind.Local).AddTicks(9541), null, null, new Guid("b8a7bb31-7655-47eb-9d59-72c0be1c8c06"), false, null, null, "Yapay Zekanın Geleceği: İnsanlık İçin Aydınlık Bir Yolculuk", 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ImageId",
                table: "Articles",
                column: "ImageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
