using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "DeveloperEntityId",
                table: "SkillEntities",
                type: "integer",
                nullable: true,
                comment: "Test",
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DeveloperEntityId",
                table: "SkillEntities",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true,
                oldComment: "Test");

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
    }
}
