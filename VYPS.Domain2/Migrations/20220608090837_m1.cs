using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VYPS.Domain2.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Akademiks",
                columns: table => new
                {
                    pkod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sicilNo = table.Column<int>(type: "int", nullable: false),
                    padi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    psoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Akademiks", x => x.pkod);
                });

            migrationBuilder.CreateTable(
                name: "Ders",
                columns: table => new
                {
                    dkod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ders", x => x.dkod);
                });

            migrationBuilder.CreateTable(
                name: "Bolumlers",
                columns: table => new
                {
                    bolumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    badi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bolumbskn = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolumlers", x => x.bolumId);
                    table.ForeignKey(
                        name: "FK_Bolumlers_Akademiks_bolumbskn",
                        column: x => x.bolumbskn,
                        principalTable: "Akademiks",
                        principalColumn: "pkod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aka_Ders",
                columns: table => new
                {
                    akaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pkod = table.Column<int>(type: "int", nullable: false),
                    dkod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aka_Ders", x => x.akaId);
                    table.ForeignKey(
                        name: "FK_Aka_Ders_Akademiks_pkod",
                        column: x => x.pkod,
                        principalTable: "Akademiks",
                        principalColumn: "pkod",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aka_Ders_Ders_dkod",
                        column: x => x.dkod,
                        principalTable: "Ders",
                        principalColumn: "dkod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notlar",
                columns: table => new
                {
                    notId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    no = table.Column<int>(type: "int", nullable: false),
                    dkod = table.Column<int>(type: "int", nullable: false),
                    vize = table.Column<int>(type: "int", nullable: false),
                    final = table.Column<int>(type: "int", nullable: false),
                    durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notlar", x => x.notId);
                    table.ForeignKey(
                        name: "FK_Notlar_Ders_dkod",
                        column: x => x.dkod,
                        principalTable: "Ders",
                        principalColumn: "dkod",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bolumid = table.Column<int>(type: "int", nullable: false),
                    dtar = table.Column<DateTime>(type: "datetime2", nullable: false),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tcno = table.Column<int>(type: "int", nullable: false),
                    cinsiyet = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.no);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Bolumlers_bolumid",
                        column: x => x.bolumid,
                        principalTable: "Bolumlers",
                        principalColumn: "bolumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aka_Ders_dkod",
                table: "Aka_Ders",
                column: "dkod");

            migrationBuilder.CreateIndex(
                name: "IX_Aka_Ders_pkod",
                table: "Aka_Ders",
                column: "pkod");

            migrationBuilder.CreateIndex(
                name: "IX_Bolumlers_bolumbskn",
                table: "Bolumlers",
                column: "bolumbskn");

            migrationBuilder.CreateIndex(
                name: "IX_Notlar_dkod",
                table: "Notlar",
                column: "dkod");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_bolumid",
                table: "Ogrencis",
                column: "bolumid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aka_Ders");

            migrationBuilder.DropTable(
                name: "Notlar");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Ders");

            migrationBuilder.DropTable(
                name: "Bolumlers");

            migrationBuilder.DropTable(
                name: "Akademiks");
        }
    }
}
