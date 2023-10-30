using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class naming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperEntities_Adresses_AdressId",
                table: "DeveloperEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillEntities_DeveloperEntities_DeveloperEntityId",
                table: "SkillEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillEntities",
                table: "SkillEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeveloperEntities",
                table: "DeveloperEntities");

            migrationBuilder.RenameTable(
                name: "SkillEntities",
                newName: "Skills");

            migrationBuilder.RenameTable(
                name: "DeveloperEntities",
                newName: "Developers");

            migrationBuilder.RenameIndex(
                name: "IX_SkillEntities_DeveloperEntityId",
                table: "Skills",
                newName: "IX_Skills_DeveloperEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_DeveloperEntities_AdressId",
                table: "Developers",
                newName: "IX_Developers_AdressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developers",
                table: "Developers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Developers_Adresses_AdressId",
                table: "Developers",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Developers_DeveloperEntityId",
                table: "Skills",
                column: "DeveloperEntityId",
                principalTable: "Developers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Developers_Adresses_AdressId",
                table: "Developers");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Developers_DeveloperEntityId",
                table: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developers",
                table: "Developers");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "SkillEntities");

            migrationBuilder.RenameTable(
                name: "Developers",
                newName: "DeveloperEntities");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_DeveloperEntityId",
                table: "SkillEntities",
                newName: "IX_SkillEntities_DeveloperEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Developers_AdressId",
                table: "DeveloperEntities",
                newName: "IX_DeveloperEntities_AdressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillEntities",
                table: "SkillEntities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeveloperEntities",
                table: "DeveloperEntities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperEntities_Adresses_AdressId",
                table: "DeveloperEntities",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillEntities_DeveloperEntities_DeveloperEntityId",
                table: "SkillEntities",
                column: "DeveloperEntityId",
                principalTable: "DeveloperEntities",
                principalColumn: "Id");
        }
    }
}
