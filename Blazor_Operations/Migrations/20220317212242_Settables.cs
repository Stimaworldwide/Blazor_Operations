using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor_Operations.Migrations
{
    public partial class Settables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DevicesTable",
                columns: table => new
                {
                    DeviceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevicesTable", x => x.DeviceID);
                });

            migrationBuilder.CreateTable(
                name: "OperationsTable",
                columns: table => new
                {
                    OperationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderInWhichToPerform = table.Column<int>(type: "int", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DeviceID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsTable", x => x.OperationID);
                    table.ForeignKey(
                        name: "FK_OperationsTable_DevicesTable_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "DevicesTable",
                        principalColumn: "DeviceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OperationsTable_DeviceID",
                table: "OperationsTable",
                column: "DeviceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationsTable");

            migrationBuilder.DropTable(
                name: "DevicesTable");
        }
    }
}
