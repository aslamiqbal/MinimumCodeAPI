using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimumCodeAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BMCarTypes",
                columns: table => new
                {
                    ROW_NUM = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarType = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    NumOfSeats = table.Column<int>(type: "int", nullable: false),
                    DefaultImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByIP = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdatedByIP = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BMCarTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BMCarTypes_CarType",
                table: "BMCarTypes",
                column: "CarType",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BMCarTypes");
        }
    }
}
