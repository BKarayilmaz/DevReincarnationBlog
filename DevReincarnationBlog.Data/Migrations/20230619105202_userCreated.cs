﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevReincarnationBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class userCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4dff3362-cae5-4561-9205-55b77cc8ae82"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a444ba6c-4bcc-4a10-b927-681c7d66e33f"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("11cb43a9-86c4-4b5c-99e4-acd4b4fee606"), new Guid("044b2971-89a5-4596-8da3-87bca0c4a7b2"), "Sanal Gerçeklik (VR) teknolojisi, günümüzdeki en heyecan verici yeniliklerden biridir. VR gözlükleri, kullanıcıları gerçek dünyadan koparıp sanal bir ortama taşıyarak tamamen yeni bir deneyim sunmaktadır. Bu inanılmaz teknoloji, eğlence sektöründen eğitim ve sağlık gibi birçok alanda çığır açmaktadır. VR gözlüklerinin geleceği ise oldukça parlak ve hayal gücümüzün sınırlarını zorlayacak.\r\n\r\nİlk olarak, eğlence sektöründe VR gözlükleri müthiş bir etki yaratmaktadır. Oyun endüstrisi, VR teknolojisi sayesinde kullanıcıları oyunların içine doğrudan yerleştirebilmekte ve daha önce hiç yaşanmamış deneyimler sunmaktadır. Gerçekçi grafikler, üç boyutlu ses efektleri ve hareket kontrolü gibi özellikler, oyuncuların oyun dünyasında tam anlamıyla kaybolmalarını sağlamaktadır. Ayrıca, VR gözlükleri sinema sektöründe de büyük bir potansiyele sahiptir. Sanal sinema deneyimi, seyircilere filmleri daha etkileyici bir şekilde deneyimleme imkanı sunacak ve izleyiciyi olayların tam merkezine yerleştirecektir.\r\n\r\nEğitim alanında VR gözlükleri, öğrenmeyi daha etkili ve eğlenceli hale getirecektir. Sanal sınıflar, öğrencilerin coğrafyayı keşfetmesine, tarihî olayları yeniden yaşamasına veya karmaşık kavramları görsel olarak anlamasına olanak tanıyacaktır. Bu, öğrencilerin daha derin bir anlayış geliştirmelerini ve daha aktif bir şekilde öğrenmelerini sağlayacaktır.\r\n\r\nSağlık alanında VR, terapi ve rehabilitasyon süreçlerinde büyük bir rol oynamaktadır. Örneğin, sanal gerçeklik tedavisi, korku veya anksiyete gibi psikolojik sorunlarla mücadelede etkili bir yöntemdir. Ayrıca, cerrahi eğitimlerde ve acil durum senaryolarında pratik yapma imkanı sunarak sağlık çalışanlarının becerilerini geliştirmelerine yardımcı olmaktadır.\r\n\r\nVR gözlükleriyle ilgili en heyecan verici şey ise potansiyelidir. Gelecekte, VR gözlüklerinin daha hafif, daha ergonomik ve daha gerçekçi hale gelmesi beklenmektedir. Ayrıca, artırılmış gerçeklik (AR) ve sanal gerçeklik (VR) teknolojilerinin birleştirilmesiyle daha etkileyici ve etkileşimli deneyimlerin ortaya çıkması muhtemeldir.\r\n\r\nSanal Gerçeklik Gözlükleri, gelecekte hayatımızı büyük ölçüde etkileyecek bir teknolojidir. Eğlence, eğitim, sağlık ve daha birçok alanda kullanılmaya devam edecek olan VR gözlükleri, insan deneyimini tamamen dönüştürerek bizi yeni dünyalara taşıyacaktır.", "Admin Test", new DateTime(2023, 6, 19, 13, 52, 2, 837, DateTimeKind.Local).AddTicks(3946), null, null, new Guid("558c3495-e0bb-4824-bcbf-a48b08263cfe"), false, null, null, "Sanal Gerçeklik Gözlükleri: Hayal Dünyasına Kapı Aralanıyor", 38 },
                    { new Guid("e0c7c25e-7030-427e-9c54-599ddd37193a"), new Guid("00b6575f-5640-4080-9dd3-7fe43b04f1e1"), "Yapay Zeka (YZ) teknolojisi, son yıllarda hızla gelişerek hayatımızın birçok alanında kendine yer edinmiştir. Ancak, YZ'nin geleceği konusunda daha heyecan verici yenilikler beklemekteyiz. Gelecekteki potansiyeli nedeniyle YZ, insanlığın önünde inanılmaz fırsatlar sunacak ve dünyayı baştan aşağı değiştirecektir.\r\n\r\nİlk olarak, YZ'nin sağlık alanında devrim yaratacağına şüphe yok. YZ destekli tanı sistemleri, tıbbi verilerin analizi ve hastalıkların erken teşhisi gibi alanlarda önemli bir rol oynayacaktır. Bu, hastaların daha iyi tedavi edilmesini ve hastalıkların önlenmesini sağlayarak sağlık hizmetlerini iyileştirecektir. YZ, karmaşık cerrahi işlemlerde de cerrahların yanında yer alacak ve bu alanda daha güvenli ve etkili müdahalelerin gerçekleştirilmesine yardımcı olacaktır.\r\n\r\nYZ'nin başka bir alanı ise ulaşım olacaktır. Otonom araçlar, trafik akışını optimize ederek trafik kazalarını ve gecikmeleri azaltacak. Ayrıca, YZ destekli lojistik sistemleri, mal taşımacılığında daha etkin ve verimli bir şekilde çalışacak ve tedarik zincirinin iyileştirilmesine katkı sağlayacaktır.\r\n\r\nEğitim sektöründe de YZ, büyük bir devrim yapacak. Öğrencilere özel eğitim programları sunarak bireyselleştirilmiş öğrenme deneyimleri sunacak ve eğitimde eşitsizlikleri azaltacak. Ayrıca, öğretmenlerin iş yükünü hafifletecek ve onlara daha fazla öğrenciye odaklanma imkanı verecektir. YZ destekli sanal gerçeklik ve artırılmış gerçeklik uygulamalarıyla da öğrenme deneyimleri daha etkileyici hale gelecektir.\r\n\r\nSon olarak, YZ'nin iş dünyasına etkisi de dikkate değerdir. YZ destekli otomasyon sistemleri, üretim süreçlerini optimize edecek ve verimliliği artıracaktır. Ayrıca, YZ'nin doğal dil işleme ve müşteri hizmetleri alanındaki ilerlemeleri, müşteri deneyimini daha kişiselleştirilmiş hale getirecektir.", "Admin Test", new DateTime(2023, 6, 19, 13, 52, 2, 837, DateTimeKind.Local).AddTicks(3934), null, null, new Guid("b8a7bb31-7655-47eb-9d59-72c0be1c8c06"), false, null, null, "Yapay Zekanın Geleceği: İnsanlık İçin Aydınlık Bir Yolculuk", 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("085d51b8-8e2b-4fe4-8d27-48c4cbeb656e"), "2aa0fea7-16d3-4aec-8d65-f9ccd98e547d", "User", "USER" },
                    { new Guid("3e48d1bc-5f79-41cd-8a9a-532140199f99"), "8c8fa83e-67c9-4503-8d6c-c3cfbc44b793", "Superadmin", "SUPERADMIN" },
                    { new Guid("989c2c1f-8ff7-4a22-925b-72275757a07d"), "aa06baa5-664a-4782-8b1a-f0718fb49fed", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1427b0e0-6e51-43e1-ad3e-040256330040"), 0, "7444d0a8-a60f-45a5-ac3f-012941ffcb1c", "admin@gmail.com", false, "Samiö", "Bayraktar", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEK/VB3KLfxCnU1G7X4N+Q460GMeMTc0wDpBLuqJZt2V2umsu0U8LifApWwLQ5x9RvQ==", "1234567899", false, "e2e6ea1a-d619-460d-abca-f9e173536718", false, "admin@gmail.com" },
                    { new Guid("c871ce76-cfac-45ea-b95c-a7dec9ef236a"), 0, "82b53401-632c-4fb2-ac9a-a2b204af58ee", "superadmin@gmail.com", true, "Ergun", "Yurdakul", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENoQzKUjFfaTquWE+WR+7SgqshxYavajkcGqRhk9XkUXQOv2JUfPvw1PHvuBcOHubQ==", "1234567890", true, "45dcc99b-3283-4345-8e6c-ecfe19364dc5", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00b6575f-5640-4080-9dd3-7fe43b04f1e1"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 19, 13, 52, 2, 837, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("044b2971-89a5-4596-8da3-87bca0c4a7b2"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 19, 13, 52, 2, 837, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("558c3495-e0bb-4824-bcbf-a48b08263cfe"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 19, 13, 52, 2, 837, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b8a7bb31-7655-47eb-9d59-72c0be1c8c06"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 19, 13, 52, 2, 837, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("989c2c1f-8ff7-4a22-925b-72275757a07d"), new Guid("1427b0e0-6e51-43e1-ad3e-040256330040") },
                    { new Guid("3e48d1bc-5f79-41cd-8a9a-532140199f99"), new Guid("c871ce76-cfac-45ea-b95c-a7dec9ef236a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("11cb43a9-86c4-4b5c-99e4-acd4b4fee606"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e0c7c25e-7030-427e-9c54-599ddd37193a"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("4dff3362-cae5-4561-9205-55b77cc8ae82"), new Guid("00b6575f-5640-4080-9dd3-7fe43b04f1e1"), "Yapay Zeka (YZ) teknolojisi, son yıllarda hızla gelişerek hayatımızın birçok alanında kendine yer edinmiştir. Ancak, YZ'nin geleceği konusunda daha heyecan verici yenilikler beklemekteyiz. Gelecekteki potansiyeli nedeniyle YZ, insanlığın önünde inanılmaz fırsatlar sunacak ve dünyayı baştan aşağı değiştirecektir.\r\n\r\nİlk olarak, YZ'nin sağlık alanında devrim yaratacağına şüphe yok. YZ destekli tanı sistemleri, tıbbi verilerin analizi ve hastalıkların erken teşhisi gibi alanlarda önemli bir rol oynayacaktır. Bu, hastaların daha iyi tedavi edilmesini ve hastalıkların önlenmesini sağlayarak sağlık hizmetlerini iyileştirecektir. YZ, karmaşık cerrahi işlemlerde de cerrahların yanında yer alacak ve bu alanda daha güvenli ve etkili müdahalelerin gerçekleştirilmesine yardımcı olacaktır.\r\n\r\nYZ'nin başka bir alanı ise ulaşım olacaktır. Otonom araçlar, trafik akışını optimize ederek trafik kazalarını ve gecikmeleri azaltacak. Ayrıca, YZ destekli lojistik sistemleri, mal taşımacılığında daha etkin ve verimli bir şekilde çalışacak ve tedarik zincirinin iyileştirilmesine katkı sağlayacaktır.\r\n\r\nEğitim sektöründe de YZ, büyük bir devrim yapacak. Öğrencilere özel eğitim programları sunarak bireyselleştirilmiş öğrenme deneyimleri sunacak ve eğitimde eşitsizlikleri azaltacak. Ayrıca, öğretmenlerin iş yükünü hafifletecek ve onlara daha fazla öğrenciye odaklanma imkanı verecektir. YZ destekli sanal gerçeklik ve artırılmış gerçeklik uygulamalarıyla da öğrenme deneyimleri daha etkileyici hale gelecektir.\r\n\r\nSon olarak, YZ'nin iş dünyasına etkisi de dikkate değerdir. YZ destekli otomasyon sistemleri, üretim süreçlerini optimize edecek ve verimliliği artıracaktır. Ayrıca, YZ'nin doğal dil işleme ve müşteri hizmetleri alanındaki ilerlemeleri, müşteri deneyimini daha kişiselleştirilmiş hale getirecektir.", "Admin Test", new DateTime(2023, 6, 13, 19, 31, 29, 130, DateTimeKind.Local).AddTicks(6243), null, null, new Guid("b8a7bb31-7655-47eb-9d59-72c0be1c8c06"), false, null, null, "Yapay Zekanın Geleceği: İnsanlık İçin Aydınlık Bir Yolculuk", 15 },
                    { new Guid("a444ba6c-4bcc-4a10-b927-681c7d66e33f"), new Guid("044b2971-89a5-4596-8da3-87bca0c4a7b2"), "Sanal Gerçeklik (VR) teknolojisi, günümüzdeki en heyecan verici yeniliklerden biridir. VR gözlükleri, kullanıcıları gerçek dünyadan koparıp sanal bir ortama taşıyarak tamamen yeni bir deneyim sunmaktadır. Bu inanılmaz teknoloji, eğlence sektöründen eğitim ve sağlık gibi birçok alanda çığır açmaktadır. VR gözlüklerinin geleceği ise oldukça parlak ve hayal gücümüzün sınırlarını zorlayacak.\r\n\r\nİlk olarak, eğlence sektöründe VR gözlükleri müthiş bir etki yaratmaktadır. Oyun endüstrisi, VR teknolojisi sayesinde kullanıcıları oyunların içine doğrudan yerleştirebilmekte ve daha önce hiç yaşanmamış deneyimler sunmaktadır. Gerçekçi grafikler, üç boyutlu ses efektleri ve hareket kontrolü gibi özellikler, oyuncuların oyun dünyasında tam anlamıyla kaybolmalarını sağlamaktadır. Ayrıca, VR gözlükleri sinema sektöründe de büyük bir potansiyele sahiptir. Sanal sinema deneyimi, seyircilere filmleri daha etkileyici bir şekilde deneyimleme imkanı sunacak ve izleyiciyi olayların tam merkezine yerleştirecektir.\r\n\r\nEğitim alanında VR gözlükleri, öğrenmeyi daha etkili ve eğlenceli hale getirecektir. Sanal sınıflar, öğrencilerin coğrafyayı keşfetmesine, tarihî olayları yeniden yaşamasına veya karmaşık kavramları görsel olarak anlamasına olanak tanıyacaktır. Bu, öğrencilerin daha derin bir anlayış geliştirmelerini ve daha aktif bir şekilde öğrenmelerini sağlayacaktır.\r\n\r\nSağlık alanında VR, terapi ve rehabilitasyon süreçlerinde büyük bir rol oynamaktadır. Örneğin, sanal gerçeklik tedavisi, korku veya anksiyete gibi psikolojik sorunlarla mücadelede etkili bir yöntemdir. Ayrıca, cerrahi eğitimlerde ve acil durum senaryolarında pratik yapma imkanı sunarak sağlık çalışanlarının becerilerini geliştirmelerine yardımcı olmaktadır.\r\n\r\nVR gözlükleriyle ilgili en heyecan verici şey ise potansiyelidir. Gelecekte, VR gözlüklerinin daha hafif, daha ergonomik ve daha gerçekçi hale gelmesi beklenmektedir. Ayrıca, artırılmış gerçeklik (AR) ve sanal gerçeklik (VR) teknolojilerinin birleştirilmesiyle daha etkileyici ve etkileşimli deneyimlerin ortaya çıkması muhtemeldir.\r\n\r\nSanal Gerçeklik Gözlükleri, gelecekte hayatımızı büyük ölçüde etkileyecek bir teknolojidir. Eğlence, eğitim, sağlık ve daha birçok alanda kullanılmaya devam edecek olan VR gözlükleri, insan deneyimini tamamen dönüştürerek bizi yeni dünyalara taşıyacaktır.", "Admin Test", new DateTime(2023, 6, 13, 19, 31, 29, 130, DateTimeKind.Local).AddTicks(6256), null, null, new Guid("558c3495-e0bb-4824-bcbf-a48b08263cfe"), false, null, null, "Sanal Gerçeklik Gözlükleri: Hayal Dünyasına Kapı Aralanıyor", 38 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00b6575f-5640-4080-9dd3-7fe43b04f1e1"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 19, 31, 29, 130, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("044b2971-89a5-4596-8da3-87bca0c4a7b2"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 19, 31, 29, 130, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("558c3495-e0bb-4824-bcbf-a48b08263cfe"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 19, 31, 29, 130, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b8a7bb31-7655-47eb-9d59-72c0be1c8c06"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 19, 31, 29, 130, DateTimeKind.Local).AddTicks(6497));
        }
    }
}
