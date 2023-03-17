using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArbitrageFinder.Infrastructure.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bet",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    GameId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Type = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UUId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TeamAId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TeamBId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UUId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Combination",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProfitMargin = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    V1Odd_BookmakerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    V1Odd_OddId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    V2Odd_BookmakerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    V2Odd_OddId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    XOdd_BookmakerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    XOdd_OddId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    BetId = table.Column<long>(type: "bigint", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UUId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Combination_Bet_BetId",
                        column: x => x.BetId,
                        principalTable: "Bet",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Odd",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookmakerId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RealOdd = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    TeamId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Type = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GameId = table.Column<long>(type: "bigint", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UUId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Odd_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Bet_UUId",
                table: "Bet",
                column: "UUId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Combination_BetId",
                table: "Combination",
                column: "BetId");

            migrationBuilder.CreateIndex(
                name: "IX_Combination_UUId",
                table: "Combination",
                column: "UUId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Game_UUId",
                table: "Game",
                column: "UUId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Odd_GameId",
                table: "Odd",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Odd_UUId",
                table: "Odd",
                column: "UUId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Combination");

            migrationBuilder.DropTable(
                name: "Odd");

            migrationBuilder.DropTable(
                name: "Bet");

            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
