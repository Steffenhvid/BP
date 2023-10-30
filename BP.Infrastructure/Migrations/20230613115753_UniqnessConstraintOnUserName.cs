using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UniqnessConstraintOnUserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER TABLE ""DeveloperEntities""
                ADD CONSTRAINT username_unq UNIQUE(""UserName"");
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER TABLE ""DeveloperEntities""
                DROP CONSTRAINT username_unq;
            ");
        }
    }
}