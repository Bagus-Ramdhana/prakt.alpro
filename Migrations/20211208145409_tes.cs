using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace alpro.Migrations
{
    public partial class tes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nasabah",
                columns: table => new
                {
                    ciff_nasabah = table.Column<string>(type: "varchar(200)", nullable: false),
                    nama_nasabah = table.Column<string>(type: "varchar(200)", nullable: true),
                    jk_nasabah = table.Column<string>(type: "varchar(200)", nullable: true),
                    alamat_nasabah = table.Column<string>(type: "varchar(200)", nullable: true),
                    nohp_nasabah = table.Column<string>(type: "varchar(200)", nullable: true),
                    pekerjaan_nasabah = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nasabah", x => x.ciff_nasabah);
                });

            migrationBuilder.CreateTable(
                name: "transaksi",
                columns: table => new
                {
                    ciff_nasabah = table.Column<string>(type: "varchar(200)", nullable: false),
                    tgl_transaksi = table.Column<DateTime>(type: "date", nullable: false),
                    jns_fasilitas = table.Column<string>(type: "varchar(200)", nullable: true),
                    nominal_transaksi = table.Column<string>(type: "varchar(200)", nullable: true),
                    keterangan_transaksi = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaksi", x => x.ciff_nasabah);
                    table.ForeignKey(
                        name: "FK_transaksi_nasabah_ciff_nasabah",
                        column: x => x.ciff_nasabah,
                        principalTable: "nasabah",
                        principalColumn: "ciff_nasabah",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "fasilitas",
                columns: table => new
                {
                    jns_fasilitas = table.Column<string>(type: "varchar(200)", nullable: false),
                    nama_fasilitas = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fasilitas", x => x.jns_fasilitas);
                    table.ForeignKey(
                        name: "FK_fasilitas_transaksi_jns_fasilitas",
                        column: x => x.jns_fasilitas,
                        principalTable: "transaksi",
                        principalColumn: "ciff_nasabah",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fasilitas");

            migrationBuilder.DropTable(
                name: "transaksi");

            migrationBuilder.DropTable(
                name: "nasabah");
        }
    }
}
