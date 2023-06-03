using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMusic.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Correct_Path_Img_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 7,
                column: "Img",
                value: "https://localhost:7250/api/Image/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 8,
                column: "Img",
                value: "https://localhost:7250/api/Image/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 9,
                column: "Img",
                value: "https://localhost:7250/api/Image/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 10,
                column: "Img",
                value: "https://localhost:7250/api/Image/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 11,
                column: "Img",
                value: "https://localhost:7250/api/Image/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 12,
                column: "Img",
                value: "https://localhost:7250/api/Image/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 13,
                column: "Img",
                value: "https://localhost:7250/api/Image/Patri.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 7,
                column: "Img",
                value: "https://localhost:7250/api/Image/Choto.jpg/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 8,
                column: "Img",
                value: "https://localhost:7250/api/Image/Choto.jpg/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 9,
                column: "Img",
                value: "https://localhost:7250/api/Image/Choto.jpg/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 10,
                column: "Img",
                value: "https://localhost:7250/api/Image/Choto.jpg/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 11,
                column: "Img",
                value: "https://localhost:7250/api/Image/Choto.jpg/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 12,
                column: "Img",
                value: "https://localhost:7250/api/Image/Choto.jpg/Patri.jpg");

            migrationBuilder.UpdateData(
                table: "InformationMusicRepository",
                keyColumn: "Id",
                keyValue: 13,
                column: "Img",
                value: "https://localhost:7250/api/Image/Choto.jpg/Patri.jpg");
        }
    }
}
