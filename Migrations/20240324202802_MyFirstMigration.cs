﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyApplication.Migrations
{
    /// <inheritdoc />
    public partial class MyFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kontrakty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataWpisu = table.Column<string>(type: "date", nullable: true),
                    StartKontraktu = table.Column<string>(type: "date", nullable: true),
                    CzyTerminowy = table.Column<bool>(type: "boolean", nullable: true),
                    KoniecKontraktu = table.Column<string>(type: "date", nullable: true),
                    NazwaProjektu = table.Column<string>(type: "text", nullable: true),
                    StawkaGodzinowa = table.Column<decimal>(type: "numeric", nullable: true),
                    StawkaMiesieczna = table.Column<decimal>(type: "numeric", nullable: true),
                    Stanowisko = table.Column<string>(type: "text", nullable: true),
                    OpisStanowiska = table.Column<string>(type: "text", nullable: true),
                    CzyOutsourcing = table.Column<bool>(type: "boolean", nullable: true),
                    NazwaZleceniodawcy = table.Column<string>(type: "text", nullable: true),
                    NipZleceniodawcy = table.Column<string>(type: "text", nullable: true),
                    AdresZleceniodawcy = table.Column<string>(type: "text", nullable: true),
                    KodPocztowyZleceniodawcy = table.Column<string>(type: "text", nullable: true),
                    MiastoZleceniodawcy = table.Column<string>(type: "text", nullable: true),
                    KrajZleceniodawcy = table.Column<string>(type: "text", nullable: true),
                    EmailZleceniodawcy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontrakty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Koszty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataWystawieniaFaktury = table.Column<string>(type: "date", nullable: true),
                    NumerFaktury = table.Column<string>(type: "text", nullable: true),
                    NipFirmy = table.Column<string>(type: "text", nullable: true),
                    OpisKosztu = table.Column<string>(type: "text", nullable: true),
                    RodzajKosztu = table.Column<string>(type: "text", nullable: true),
                    WartoscNetto = table.Column<decimal>(type: "numeric", nullable: true),
                    WartoscVat = table.Column<decimal>(type: "numeric", nullable: true),
                    WartoscBrutto = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koszty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Podatek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataWpisu = table.Column<string>(type: "date", nullable: true),
                    Rok = table.Column<int>(type: "integer", nullable: true),
                    Miesiac = table.Column<int>(type: "integer", nullable: true),
                    VatDoOdliczenia = table.Column<decimal>(type: "numeric", nullable: true),
                    PitDoZaplaty = table.Column<decimal>(type: "numeric", nullable: true),
                    VatDoZaplaty = table.Column<decimal>(type: "numeric", nullable: true),
                    ZusDoZaplaty = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podatek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Przychody",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataWystawieniaFaktury = table.Column<string>(type: "date", nullable: true),
                    TerminPlatnosci = table.Column<string>(type: "date", nullable: true),
                    NumerFaktury = table.Column<string>(type: "text", nullable: true),
                    NipKlienta = table.Column<string>(type: "text", nullable: true),
                    OpisFaktury = table.Column<string>(type: "text", nullable: true),
                    WartoscNetto = table.Column<decimal>(type: "numeric", nullable: true),
                    WartoscVat = table.Column<decimal>(type: "numeric", nullable: true),
                    WartoscBrutto = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przychody", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RaportGodzinPracy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataWpisu = table.Column<string>(type: "date", nullable: true),
                    DataAktywnosci = table.Column<string>(type: "date", nullable: true),
                    CzyPraca = table.Column<bool>(type: "boolean", nullable: true),
                    NazwaProjektu = table.Column<string>(type: "text", nullable: true),
                    IleGodzin = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaportGodzinPracy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZestawienieGodzinPracy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataWpisu = table.Column<string>(type: "date", nullable: true),
                    Rok = table.Column<int>(type: "integer", nullable: true),
                    Miesiac = table.Column<int>(type: "integer", nullable: true),
                    NazwaProjektu = table.Column<string>(type: "text", nullable: true),
                    IleGodzin = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZestawienieGodzinPracy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZestawienieMiesieczneFirmy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataWpisu = table.Column<string>(type: "date", nullable: true),
                    Rok = table.Column<int>(type: "integer", nullable: true),
                    Miesiac = table.Column<int>(type: "integer", nullable: true),
                    KosztyBiuro = table.Column<decimal>(type: "numeric", nullable: true),
                    KosztyAuto = table.Column<decimal>(type: "numeric", nullable: true),
                    KosztyLacznie = table.Column<decimal>(type: "numeric", nullable: true),
                    PrzychodyLacznie = table.Column<decimal>(type: "numeric", nullable: true),
                    VatLacznie = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZestawienieMiesieczneFirmy", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kontrakty");

            migrationBuilder.DropTable(
                name: "Koszty");

            migrationBuilder.DropTable(
                name: "Podatek");

            migrationBuilder.DropTable(
                name: "Przychody");

            migrationBuilder.DropTable(
                name: "RaportGodzinPracy");

            migrationBuilder.DropTable(
                name: "ZestawienieGodzinPracy");

            migrationBuilder.DropTable(
                name: "ZestawienieMiesieczneFirmy");
        }
    }
}
