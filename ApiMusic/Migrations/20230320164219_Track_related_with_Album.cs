using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMusic.Migrations
{
    /// <inheritdoc />
    public partial class Track_related_with_Album : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CardTrackRepository",
                columns: new[] { "Id", "CardAlbumRepositoryId", "CardArtistRepositoryId", "CardPlayListRepositoryId", "InformationMusicRepositoryId", "IsPlay" },
                values: new object[] { 4, null, null, null, 14, false });
        }
    }
}
