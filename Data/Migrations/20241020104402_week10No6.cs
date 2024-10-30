using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreMvcWebSite.Data.Migrations
{
    /// <inheritdoc />
    public partial class week10No6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CanIncreaseLike",
                table: "DiscussionForum",
                newName: "canIncreaseLike");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "canIncreaseLike",
                table: "DiscussionForum",
                newName: "CanIncreaseLike");
        }
    }
}
