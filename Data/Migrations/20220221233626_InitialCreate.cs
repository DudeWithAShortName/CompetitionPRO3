using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Competition_PRO.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Juries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuryCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JuryMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JuryMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JuryMembers_Juries_JuryId",
                        column: x => x.JuryId,
                        principalTable: "Juries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamParticipants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamParticipants_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BestDrivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuryMemberId = table.Column<int>(type: "int", nullable: false),
                    TeamParticipantId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    PenaltySeconds = table.Column<TimeSpan>(type: "time", nullable: false),
                    TotalTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    TotalPoints = table.Column<int>(type: "int", nullable: false),
                    JuryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BestDrivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BestDrivers_Juries_JuryId",
                        column: x => x.JuryId,
                        principalTable: "Juries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BestDrivers_TeamParticipants_TeamParticipantId",
                        column: x => x.TeamParticipantId,
                        principalTable: "TeamParticipants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BestMechanics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipantId = table.Column<int>(type: "int", nullable: false),
                    JuryLeaderPoints = table.Column<int>(type: "int", nullable: false),
                    JuryMember1Points = table.Column<int>(type: "int", nullable: false),
                    JuryMember2Points = table.Column<int>(type: "int", nullable: false),
                    JuryMember3Points = table.Column<int>(type: "int", nullable: false),
                    WorkPostNumber = table.Column<int>(type: "int", nullable: false),
                    AveragePoints = table.Column<int>(type: "int", nullable: false),
                    Ranking = table.Column<int>(type: "int", nullable: false),
                    TeamParticipantsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BestMechanics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BestMechanics_TeamParticipants_TeamParticipantsId",
                        column: x => x.TeamParticipantsId,
                        principalTable: "TeamParticipants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TheoryTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipantId = table.Column<int>(type: "int", nullable: false),
                    PointsMPS = table.Column<int>(type: "int", nullable: false),
                    PointsMechanic = table.Column<int>(type: "int", nullable: false),
                    TeamParticipantsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheoryTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TheoryTests_TeamParticipants_TeamParticipantsId",
                        column: x => x.TeamParticipantsId,
                        principalTable: "TeamParticipants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BestDrivers_JuryId",
                table: "BestDrivers",
                column: "JuryId");

            migrationBuilder.CreateIndex(
                name: "IX_BestDrivers_TeamParticipantId",
                table: "BestDrivers",
                column: "TeamParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_BestMechanics_TeamParticipantsId",
                table: "BestMechanics",
                column: "TeamParticipantsId");

            migrationBuilder.CreateIndex(
                name: "IX_JuryMembers_JuryId",
                table: "JuryMembers",
                column: "JuryId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamParticipants_TeamId",
                table: "TeamParticipants",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TheoryTests_TeamParticipantsId",
                table: "TheoryTests",
                column: "TeamParticipantsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BestDrivers");

            migrationBuilder.DropTable(
                name: "BestMechanics");

            migrationBuilder.DropTable(
                name: "JuryMembers");

            migrationBuilder.DropTable(
                name: "TheoryTests");

            migrationBuilder.DropTable(
                name: "Juries");

            migrationBuilder.DropTable(
                name: "TeamParticipants");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
