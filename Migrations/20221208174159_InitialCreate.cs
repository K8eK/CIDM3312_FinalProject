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
                name: "CollectionLayers",
                columns: table => new
                {
                    CollectionLayerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CollectionCode = table.Column<string>(type: "TEXT", nullable: false),
                    CollectionLabel = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionLayers", x => x.CollectionLayerId);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacilityCode = table.Column<string>(type: "TEXT", maxLength: 7, nullable: false),
                    FacilityName = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    GwtgFacilityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.FacilityId);
                });

            migrationBuilder.CreateTable(
                name: "FacilityCollections",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "INTEGER", nullable: false),
                    CollectionLayerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityCollections", x => new { x.FacilityId, x.CollectionLayerId });
                    table.ForeignKey(
                        name: "FK_FacilityCollections_CollectionLayers_CollectionLayerId",
                        column: x => x.CollectionLayerId,
                        principalTable: "CollectionLayers",
                        principalColumn: "CollectionLayerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacilityCollections_Facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facilities",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacilityCollections_CollectionLayerId",
                table: "FacilityCollections",
                column: "CollectionLayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacilityCollections");

            migrationBuilder.DropTable(
                name: "CollectionLayers");

            migrationBuilder.DropTable(
                name: "Facilities");
        }
    }
}
