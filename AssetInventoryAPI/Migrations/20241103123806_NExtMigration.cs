using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetInventoryAPI.Migrations
{
    /// <inheritdoc />
    public partial class NExtMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetInv",
                columns: table => new
                {
                    agreement_number = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bpkb_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bpkb_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    faktur_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    faktur_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    location_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    police_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bpkb_date_in = table.Column<DateTime>(type: "datetime2", nullable: false),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastupdated_by = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetInv", x => x.agreement_number);
                });
                    }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetInv");

            migrationBuilder.DropTable(
                name: "UserMaster");
        }
    }
}
