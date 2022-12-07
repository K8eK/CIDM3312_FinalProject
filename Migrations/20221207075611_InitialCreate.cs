﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CIDM3312FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CollectionLayer",
                columns: table => new
                {
                    CollectionLayerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CollectionCode = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    CollectionLabel = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionLayer", x => x.CollectionLayerId);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacilityCode = table.Column<string>(type: "TEXT", nullable: false),
                    FacilityName = table.Column<string>(type: "TEXT", nullable: false),
                    GwtgFacilityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.FacilityId);
                });

            migrationBuilder.CreateTable(
                name: "FacilityCollection",
                columns: table => new
                {
                    FcRowId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CollectionLayerId = table.Column<int>(type: "INTEGER", nullable: false),
                    FacilityId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParticipationStartDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    ParticipationEndDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityCollection", x => x.FcRowId);
                    table.ForeignKey(
                        name: "FK_FacilityCollection_CollectionLayer_CollectionLayerId",
                        column: x => x.CollectionLayerId,
                        principalTable: "CollectionLayer",
                        principalColumn: "CollectionLayerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacilityCollection_Facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facilities",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacilityCollection_CollectionLayerId",
                table: "FacilityCollection",
                column: "CollectionLayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityCollection_FacilityId",
                table: "FacilityCollection",
                column: "FacilityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacilityCollection");

            migrationBuilder.DropTable(
                name: "CollectionLayer");

            migrationBuilder.DropTable(
                name: "Facilities");
        }
    }
}
