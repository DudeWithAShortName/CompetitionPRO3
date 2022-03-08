using Microsoft.EntityFrameworkCore.Migrations;

namespace Competition_PRO.Data.Migrations
{
    public partial class mechanicprimaryy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MechanicPrimaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamParticipantId = table.Column<int>(type: "int", nullable: false),
                    WorkPostId = table.Column<int>(type: "int", nullable: false),
                    JuryMemberId = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MechanicPrimaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MechanicPrimaries_JuryMembers_JuryMemberId",
                        column: x => x.JuryMemberId,
                        principalTable: "JuryMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MechanicPrimaries_TeamParticipants_TeamParticipantId",
                        column: x => x.TeamParticipantId,
                        principalTable: "TeamParticipants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MechanicPrimaries_JuryMemberId",
                table: "MechanicPrimaries",
                column: "JuryMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MechanicPrimaries_TeamParticipantId",
                table: "MechanicPrimaries",
                column: "TeamParticipantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MechanicPrimaries");
        }
    }
}
