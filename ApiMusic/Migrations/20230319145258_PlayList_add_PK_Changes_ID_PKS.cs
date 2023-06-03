using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMusic.Migrations
{
    /// <inheritdoc />
    public partial class PlayList_add_PK_Changes_ID_PKS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "CardArtistRepositoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "CardPlayListRepositoryId",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "CardArtistRepositoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "CardPlayListRepositoryId",
                value: 3);
        }
    }
}
