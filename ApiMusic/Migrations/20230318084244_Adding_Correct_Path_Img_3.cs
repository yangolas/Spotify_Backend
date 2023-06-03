using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMusic.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Correct_Path_Img_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "Img",
                value: "https://localhost:7250/api/Image/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Armin Van Buuren");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Patrizienta");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Patrizienta");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Patrizienta");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Patrizienta");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Patrizienta");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Patrizienta");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Patrizienta");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Natos y waor");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Natos y waor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "Img",
                value: "Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "");
        }
    }
}
