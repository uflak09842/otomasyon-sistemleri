using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hafta_8_emlak_b.Migrations
{
    /// <inheritdoc />
    public partial class otomasyonlar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aktiviteler",
                columns: table => new
                {
                    aktiviteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aktiviteAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktiviteler", x => x.aktiviteId);
                });

            migrationBuilder.CreateTable(
                name: "BaglantiTipler",
                columns: table => new
                {
                    baglantiTipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    baglatiTipi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaglantiTipler", x => x.baglantiTipId);
                });

            migrationBuilder.CreateTable(
                name: "Bataryalar",
                columns: table => new
                {
                    bataryaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bataryaMiktarı = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bataryalar", x => x.bataryaId);
                });

            migrationBuilder.CreateTable(
                name: "Bluetoothlar",
                columns: table => new
                {
                    btId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    btVar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bluetoothlar", x => x.btId);
                });

            migrationBuilder.CreateTable(
                name: "BtStandartlar",
                columns: table => new
                {
                    btStandartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    btStandart = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtStandartlar", x => x.btStandartId);
                });

            migrationBuilder.CreateTable(
                name: "Compability5Gler",
                columns: table => new
                {
                    comp5GId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comp5GVar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compability5Gler", x => x.comp5GId);
                });

            migrationBuilder.CreateTable(
                name: "CpuHzler",
                columns: table => new
                {
                    cpuHzId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpuHz = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CpuHzler", x => x.cpuHzId);
                });

            migrationBuilder.CreateTable(
                name: "Depolamalar",
                columns: table => new
                {
                    depolamaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    depolamaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depolamalar", x => x.depolamaId);
                });

            migrationBuilder.CreateTable(
                name: "EkranCozler",
                columns: table => new
                {
                    ekranCozId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ekranCozYatay = table.Column<int>(type: "int", nullable: false),
                    ekranCozDikey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkranCozler", x => x.ekranCozId);
                });

            migrationBuilder.CreateTable(
                name: "Hatlar",
                columns: table => new
                {
                    hatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hatTur = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hatlar", x => x.hatId);
                });

            migrationBuilder.CreateTable(
                name: "HizliSarjlar",
                columns: table => new
                {
                    hSarjId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hSarjVar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizliSarjlar", x => x.hSarjId);
                });

            migrationBuilder.CreateTable(
                name: "KameraCozler",
                columns: table => new
                {
                    kameraCozId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kameraCoz = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KameraCozler", x => x.kameraCozId);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KatAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KatId);
                });

            migrationBuilder.CreateTable(
                name: "Markalar",
                columns: table => new
                {
                    markaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    markaAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markalar", x => x.markaId);
                });

            migrationBuilder.CreateTable(
                name: "Mikrofonlar",
                columns: table => new
                {
                    mikrofonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mikrofonVar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mikrofonlar", x => x.mikrofonId);
                });

            migrationBuilder.CreateTable(
                name: "Olanaklar",
                columns: table => new
                {
                    olanakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    olanakAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olanaklar", x => x.olanakId);
                });

            migrationBuilder.CreateTable(
                name: "ParmakIzler",
                columns: table => new
                {
                    parmakIziId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parmakIziVar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParmakIzler", x => x.parmakIziId);
                });

            migrationBuilder.CreateTable(
                name: "Ramler",
                columns: table => new
                {
                    ramId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ramMiktari = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ramler", x => x.ramId);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    Plaka = table.Column<int>(type: "int", nullable: false),
                    SehirAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.Plaka);
                });

            migrationBuilder.CreateTable(
                name: "SesCikislar",
                columns: table => new
                {
                    sesCikisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sesCikisTur = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SesCikislar", x => x.sesCikisId);
                });

            migrationBuilder.CreateTable(
                name: "Siniflar",
                columns: table => new
                {
                    sinifId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sinifAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siniflar", x => x.sinifId);
                });

            migrationBuilder.CreateTable(
                name: "Sular",
                columns: table => new
                {
                    suDayanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    suDayananikli = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sular", x => x.suDayanId);
                });

            migrationBuilder.CreateTable(
                name: "SuSertifikalar",
                columns: table => new
                {
                    suSertifikaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    suSertifikaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuSertifikalar", x => x.suSertifikaId);
                });

            migrationBuilder.CreateTable(
                name: "TelMarkalar",
                columns: table => new
                {
                    telMarkaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    telMarkaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelMarkalar", x => x.telMarkaId);
                });

            migrationBuilder.CreateTable(
                name: "UrunDurumlar",
                columns: table => new
                {
                    durumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    durumAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunDurumlar", x => x.durumId);
                });

            migrationBuilder.CreateTable(
                name: "UrunKategoriler",
                columns: table => new
                {
                    ukId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ukAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunKategoriler", x => x.ukId);
                });

            migrationBuilder.CreateTable(
                name: "UyelikTipler",
                columns: table => new
                {
                    uyelikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uyelikAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UyelikTipler", x => x.uyelikId);
                });

            migrationBuilder.CreateTable(
                name: "Vitesler",
                columns: table => new
                {
                    vitesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vitesAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitesler", x => x.vitesId);
                });

            migrationBuilder.CreateTable(
                name: "Yakitlar",
                columns: table => new
                {
                    yakitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yakitName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yakitlar", x => x.yakitId);
                });

            migrationBuilder.CreateTable(
                name: "Ilceler",
                columns: table => new
                {
                    ilceId = table.Column<int>(type: "int", nullable: false),
                    ilceAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plaka = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilceler", x => x.ilceId);
                    table.ForeignKey(
                        name: "FK_Ilceler_Sehirler_Plaka",
                        column: x => x.Plaka,
                        principalTable: "Sehirler",
                        principalColumn: "Plaka",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kulakliklar",
                columns: table => new
                {
                    kulaklikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kulaklikAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fiyat = table.Column<float>(type: "real", nullable: false),
                    sesCikisId = table.Column<int>(type: "int", nullable: false),
                    baglantiTipId = table.Column<int>(type: "int", nullable: false),
                    btId = table.Column<int>(type: "int", nullable: false),
                    btStandartId = table.Column<int>(type: "int", nullable: false),
                    mikrofonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kulakliklar", x => x.kulaklikId);
                    table.ForeignKey(
                        name: "FK_Kulakliklar_BaglantiTipler_baglantiTipId",
                        column: x => x.baglantiTipId,
                        principalTable: "BaglantiTipler",
                        principalColumn: "baglantiTipId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kulakliklar_Bluetoothlar_btId",
                        column: x => x.btId,
                        principalTable: "Bluetoothlar",
                        principalColumn: "btId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kulakliklar_BtStandartlar_btStandartId",
                        column: x => x.btStandartId,
                        principalTable: "BtStandartlar",
                        principalColumn: "btStandartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kulakliklar_Mikrofonlar_mikrofonId",
                        column: x => x.mikrofonId,
                        principalTable: "Mikrofonlar",
                        principalColumn: "mikrofonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kulakliklar_SesCikislar_sesCikisId",
                        column: x => x.sesCikisId,
                        principalTable: "SesCikislar",
                        principalColumn: "sesCikisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefonlar",
                columns: table => new
                {
                    telId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    telAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fiyat = table.Column<float>(type: "real", nullable: false),
                    telMarkaId = table.Column<int>(type: "int", nullable: false),
                    depolamaId = table.Column<int>(type: "int", nullable: false),
                    ramId = table.Column<int>(type: "int", nullable: false),
                    bataryaId = table.Column<int>(type: "int", nullable: false),
                    hatId = table.Column<int>(type: "int", nullable: false),
                    hSarjId = table.Column<int>(type: "int", nullable: false),
                    comp5GId = table.Column<int>(type: "int", nullable: false),
                    suDayanId = table.Column<int>(type: "int", nullable: false),
                    suSertifikaId = table.Column<int>(type: "int", nullable: false),
                    cpuHzId = table.Column<int>(type: "int", nullable: false),
                    kameraCozId = table.Column<int>(type: "int", nullable: false),
                    ekranCozId = table.Column<int>(type: "int", nullable: false),
                    parmakIziId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonlar", x => x.telId);
                    table.ForeignKey(
                        name: "FK_Telefonlar_Bataryalar_bataryaId",
                        column: x => x.bataryaId,
                        principalTable: "Bataryalar",
                        principalColumn: "bataryaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_Compability5Gler_comp5GId",
                        column: x => x.comp5GId,
                        principalTable: "Compability5Gler",
                        principalColumn: "comp5GId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_CpuHzler_cpuHzId",
                        column: x => x.cpuHzId,
                        principalTable: "CpuHzler",
                        principalColumn: "cpuHzId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_Depolamalar_depolamaId",
                        column: x => x.depolamaId,
                        principalTable: "Depolamalar",
                        principalColumn: "depolamaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_EkranCozler_ekranCozId",
                        column: x => x.ekranCozId,
                        principalTable: "EkranCozler",
                        principalColumn: "ekranCozId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_Hatlar_hatId",
                        column: x => x.hatId,
                        principalTable: "Hatlar",
                        principalColumn: "hatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_HizliSarjlar_hSarjId",
                        column: x => x.hSarjId,
                        principalTable: "HizliSarjlar",
                        principalColumn: "hSarjId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_KameraCozler_kameraCozId",
                        column: x => x.kameraCozId,
                        principalTable: "KameraCozler",
                        principalColumn: "kameraCozId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_ParmakIzler_parmakIziId",
                        column: x => x.parmakIziId,
                        principalTable: "ParmakIzler",
                        principalColumn: "parmakIziId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_Ramler_ramId",
                        column: x => x.ramId,
                        principalTable: "Ramler",
                        principalColumn: "ramId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_SuSertifikalar_suSertifikaId",
                        column: x => x.suSertifikaId,
                        principalTable: "SuSertifikalar",
                        principalColumn: "suSertifikaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_Sular_suDayanId",
                        column: x => x.suDayanId,
                        principalTable: "Sular",
                        principalColumn: "suDayanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefonlar_TelMarkalar_telMarkaId",
                        column: x => x.telMarkaId,
                        principalTable: "TelMarkalar",
                        principalColumn: "telMarkaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emlaklar",
                columns: table => new
                {
                    EmlakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmlakAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KatId = table.Column<int>(type: "int", nullable: false),
                    ilceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emlaklar", x => x.EmlakId);
                    table.ForeignKey(
                        name: "FK_Emlaklar_Ilceler_ilceId",
                        column: x => x.ilceId,
                        principalTable: "Ilceler",
                        principalColumn: "ilceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emlaklar_Kategoriler_KatId",
                        column: x => x.KatId,
                        principalTable: "Kategoriler",
                        principalColumn: "KatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IkinciEller",
                columns: table => new
                {
                    urunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urunBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urunFiyat = table.Column<int>(type: "int", nullable: false),
                    ukId = table.Column<int>(type: "int", nullable: false),
                    durumId = table.Column<int>(type: "int", nullable: false),
                    ilceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IkinciEller", x => x.urunId);
                    table.ForeignKey(
                        name: "FK_IkinciEller_Ilceler_ilceId",
                        column: x => x.ilceId,
                        principalTable: "Ilceler",
                        principalColumn: "ilceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IkinciEller_UrunDurumlar_durumId",
                        column: x => x.durumId,
                        principalTable: "UrunDurumlar",
                        principalColumn: "durumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IkinciEller_UrunKategoriler_ukId",
                        column: x => x.ukId,
                        principalTable: "UrunKategoriler",
                        principalColumn: "ukId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kurslar",
                columns: table => new
                {
                    kursId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kursAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    sinifId = table.Column<int>(type: "int", nullable: false),
                    ilceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurslar", x => x.kursId);
                    table.ForeignKey(
                        name: "FK_Kurslar_Ilceler_ilceId",
                        column: x => x.ilceId,
                        principalTable: "Ilceler",
                        principalColumn: "ilceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kurslar_Siniflar_sinifId",
                        column: x => x.sinifId,
                        principalTable: "Siniflar",
                        principalColumn: "sinifId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Otomotivler",
                columns: table => new
                {
                    otoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    otoAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    otoYil = table.Column<int>(type: "int", nullable: false),
                    otoKm = table.Column<int>(type: "int", nullable: false),
                    otoRenk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    otoFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    markaId = table.Column<int>(type: "int", nullable: false),
                    yakitId = table.Column<int>(type: "int", nullable: false),
                    vitesId = table.Column<int>(type: "int", nullable: false),
                    ilceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otomotivler", x => x.otoId);
                    table.ForeignKey(
                        name: "FK_Otomotivler_Ilceler_ilceId",
                        column: x => x.ilceId,
                        principalTable: "Ilceler",
                        principalColumn: "ilceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Otomotivler_Markalar_markaId",
                        column: x => x.markaId,
                        principalTable: "Markalar",
                        principalColumn: "markaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Otomotivler_Vitesler_vitesId",
                        column: x => x.vitesId,
                        principalTable: "Vitesler",
                        principalColumn: "vitesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Otomotivler_Yakitlar_yakitId",
                        column: x => x.yakitId,
                        principalTable: "Yakitlar",
                        principalColumn: "yakitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SporSalonlar",
                columns: table => new
                {
                    salonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salonAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    uyelikId = table.Column<int>(type: "int", nullable: false),
                    aktiviteId = table.Column<int>(type: "int", nullable: false),
                    olanakId = table.Column<int>(type: "int", nullable: false),
                    ilceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SporSalonlar", x => x.salonId);
                    table.ForeignKey(
                        name: "FK_SporSalonlar_Aktiviteler_aktiviteId",
                        column: x => x.aktiviteId,
                        principalTable: "Aktiviteler",
                        principalColumn: "aktiviteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SporSalonlar_Ilceler_ilceId",
                        column: x => x.ilceId,
                        principalTable: "Ilceler",
                        principalColumn: "ilceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SporSalonlar_Olanaklar_olanakId",
                        column: x => x.olanakId,
                        principalTable: "Olanaklar",
                        principalColumn: "olanakId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SporSalonlar_UyelikTipler_uyelikId",
                        column: x => x.uyelikId,
                        principalTable: "UyelikTipler",
                        principalColumn: "uyelikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emlaklar_ilceId",
                table: "Emlaklar",
                column: "ilceId");

            migrationBuilder.CreateIndex(
                name: "IX_Emlaklar_KatId",
                table: "Emlaklar",
                column: "KatId");

            migrationBuilder.CreateIndex(
                name: "IX_IkinciEller_durumId",
                table: "IkinciEller",
                column: "durumId");

            migrationBuilder.CreateIndex(
                name: "IX_IkinciEller_ilceId",
                table: "IkinciEller",
                column: "ilceId");

            migrationBuilder.CreateIndex(
                name: "IX_IkinciEller_ukId",
                table: "IkinciEller",
                column: "ukId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilceler_Plaka",
                table: "Ilceler",
                column: "Plaka");

            migrationBuilder.CreateIndex(
                name: "IX_Kulakliklar_baglantiTipId",
                table: "Kulakliklar",
                column: "baglantiTipId");

            migrationBuilder.CreateIndex(
                name: "IX_Kulakliklar_btId",
                table: "Kulakliklar",
                column: "btId");

            migrationBuilder.CreateIndex(
                name: "IX_Kulakliklar_btStandartId",
                table: "Kulakliklar",
                column: "btStandartId");

            migrationBuilder.CreateIndex(
                name: "IX_Kulakliklar_mikrofonId",
                table: "Kulakliklar",
                column: "mikrofonId");

            migrationBuilder.CreateIndex(
                name: "IX_Kulakliklar_sesCikisId",
                table: "Kulakliklar",
                column: "sesCikisId");

            migrationBuilder.CreateIndex(
                name: "IX_Kurslar_ilceId",
                table: "Kurslar",
                column: "ilceId");

            migrationBuilder.CreateIndex(
                name: "IX_Kurslar_sinifId",
                table: "Kurslar",
                column: "sinifId");

            migrationBuilder.CreateIndex(
                name: "IX_Otomotivler_ilceId",
                table: "Otomotivler",
                column: "ilceId");

            migrationBuilder.CreateIndex(
                name: "IX_Otomotivler_markaId",
                table: "Otomotivler",
                column: "markaId");

            migrationBuilder.CreateIndex(
                name: "IX_Otomotivler_vitesId",
                table: "Otomotivler",
                column: "vitesId");

            migrationBuilder.CreateIndex(
                name: "IX_Otomotivler_yakitId",
                table: "Otomotivler",
                column: "yakitId");

            migrationBuilder.CreateIndex(
                name: "IX_SporSalonlar_aktiviteId",
                table: "SporSalonlar",
                column: "aktiviteId");

            migrationBuilder.CreateIndex(
                name: "IX_SporSalonlar_ilceId",
                table: "SporSalonlar",
                column: "ilceId");

            migrationBuilder.CreateIndex(
                name: "IX_SporSalonlar_olanakId",
                table: "SporSalonlar",
                column: "olanakId");

            migrationBuilder.CreateIndex(
                name: "IX_SporSalonlar_uyelikId",
                table: "SporSalonlar",
                column: "uyelikId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_bataryaId",
                table: "Telefonlar",
                column: "bataryaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_comp5GId",
                table: "Telefonlar",
                column: "comp5GId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_cpuHzId",
                table: "Telefonlar",
                column: "cpuHzId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_depolamaId",
                table: "Telefonlar",
                column: "depolamaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_ekranCozId",
                table: "Telefonlar",
                column: "ekranCozId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_hatId",
                table: "Telefonlar",
                column: "hatId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_hSarjId",
                table: "Telefonlar",
                column: "hSarjId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_kameraCozId",
                table: "Telefonlar",
                column: "kameraCozId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_parmakIziId",
                table: "Telefonlar",
                column: "parmakIziId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_ramId",
                table: "Telefonlar",
                column: "ramId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_suDayanId",
                table: "Telefonlar",
                column: "suDayanId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_suSertifikaId",
                table: "Telefonlar",
                column: "suSertifikaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonlar_telMarkaId",
                table: "Telefonlar",
                column: "telMarkaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emlaklar");

            migrationBuilder.DropTable(
                name: "IkinciEller");

            migrationBuilder.DropTable(
                name: "Kulakliklar");

            migrationBuilder.DropTable(
                name: "Kurslar");

            migrationBuilder.DropTable(
                name: "Otomotivler");

            migrationBuilder.DropTable(
                name: "SporSalonlar");

            migrationBuilder.DropTable(
                name: "Telefonlar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "UrunDurumlar");

            migrationBuilder.DropTable(
                name: "UrunKategoriler");

            migrationBuilder.DropTable(
                name: "BaglantiTipler");

            migrationBuilder.DropTable(
                name: "Bluetoothlar");

            migrationBuilder.DropTable(
                name: "BtStandartlar");

            migrationBuilder.DropTable(
                name: "Mikrofonlar");

            migrationBuilder.DropTable(
                name: "SesCikislar");

            migrationBuilder.DropTable(
                name: "Siniflar");

            migrationBuilder.DropTable(
                name: "Markalar");

            migrationBuilder.DropTable(
                name: "Vitesler");

            migrationBuilder.DropTable(
                name: "Yakitlar");

            migrationBuilder.DropTable(
                name: "Aktiviteler");

            migrationBuilder.DropTable(
                name: "Ilceler");

            migrationBuilder.DropTable(
                name: "Olanaklar");

            migrationBuilder.DropTable(
                name: "UyelikTipler");

            migrationBuilder.DropTable(
                name: "Bataryalar");

            migrationBuilder.DropTable(
                name: "Compability5Gler");

            migrationBuilder.DropTable(
                name: "CpuHzler");

            migrationBuilder.DropTable(
                name: "Depolamalar");

            migrationBuilder.DropTable(
                name: "EkranCozler");

            migrationBuilder.DropTable(
                name: "Hatlar");

            migrationBuilder.DropTable(
                name: "HizliSarjlar");

            migrationBuilder.DropTable(
                name: "KameraCozler");

            migrationBuilder.DropTable(
                name: "ParmakIzler");

            migrationBuilder.DropTable(
                name: "Ramler");

            migrationBuilder.DropTable(
                name: "SuSertifikalar");

            migrationBuilder.DropTable(
                name: "Sular");

            migrationBuilder.DropTable(
                name: "TelMarkalar");

            migrationBuilder.DropTable(
                name: "Sehirler");
        }
    }
}
