using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeveloperId",
                table: "DeveloperEntities",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeveloperEntities_DeveloperId",
                table: "DeveloperEntities",
                column: "DeveloperId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperEntities_SkillEntities_DeveloperId",
                table: "DeveloperEntities",
                column: "DeveloperId",
                principalTable: "SkillEntities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperEntities_SkillEntities_DeveloperId",
                table: "DeveloperEntities");

            migrationBuilder.DropIndex(
                name: "IX_DeveloperEntities_DeveloperId",
                table: "DeveloperEntities");

            migrationBuilder.DropColumn(
                name: "DeveloperId",
                table: "DeveloperEntities");
        }
    }
}