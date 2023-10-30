using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class testmanytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillEntityId",
                table: "Developers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Developers_SkillEntityId",
                table: "Developers",
                column: "SkillEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Developers_Skills_SkillEntityId",
                table: "Developers",
                column: "SkillEntityId",
                principalTable: "Skills",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Developers_Skills_SkillEntityId",
                table: "Developers");

            migrationBuilder.DropIndex(
                name: "IX_Developers_SkillEntityId",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "SkillEntityId",
                table: "Developers");
        }
    }
}
