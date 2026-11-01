using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C48_G02_EF02.Migrations
{
    /// <inheritdoc />
    public partial class RelationAttBadges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttendeeId",
                table: "Badges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BadgeId",
                table: "Attendees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_BadgeId",
                table: "Attendees",
                column: "BadgeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Badges_BadgeId",
                table: "Attendees",
                column: "BadgeId",
                principalTable: "Badges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Badges_BadgeId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_BadgeId",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "Badges");

            migrationBuilder.DropColumn(
                name: "BadgeId",
                table: "Attendees");
        }
    }
}
