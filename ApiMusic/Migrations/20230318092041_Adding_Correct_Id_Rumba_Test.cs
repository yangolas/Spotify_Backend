using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMusic.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Correct_Id_Rumba_Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "InformationMusicRepositoryId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "InformationMusicRepositoryId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "InformationMusicRepositoryId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 4,
                column: "InformationMusicRepositoryId",
                value: 14);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "InformationMusicRepositoryId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "InformationMusicRepositoryId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "InformationMusicRepositoryId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 4,
                column: "InformationMusicRepositoryId",
                value: 13);
        }
    }
}
