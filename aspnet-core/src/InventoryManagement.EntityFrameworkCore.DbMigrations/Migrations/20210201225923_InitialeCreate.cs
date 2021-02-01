using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Migrations
{
    public partial class InitialeCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppEnumerations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Code = table.Column<int>(type: "INTEGER", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true),
                    IdParent = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayFr = table.Column<string>(type: "TEXT", nullable: true),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEnumerations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppEnumerations");
        }
    }
}
