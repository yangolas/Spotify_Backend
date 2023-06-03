using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMusic.Migrations
{
    /// <inheritdoc />
    public partial class Add_PlayerStatus_Artist_Album_PlayList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsPlay",
                table: "CardPlayListRepository",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsPlay",
                table: "CardArtistRepository",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsPlay",
                table: "CardAlbumRepository",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CardAlbumRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsPlay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsPlay",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPlay",
                table: "CardPlayListRepository");

            migrationBuilder.DropColumn(
                name: "IsPlay",
                table: "CardArtistRepository");

            migrationBuilder.DropColumn(
                name: "IsPlay",
                table: "CardAlbumRepository");
        }
    }
}
