using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMusic.Migrations
{
    /// <inheritdoc />
    public partial class Change_PlayerStatus_for_IsPlay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsPlay",
                table: "CardTrackRepository",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "IsPlay",
                table: "CardPlayListRepository",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsPlay",
                table: "CardArtistRepository",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsPlay",
                table: "CardAlbumRepository",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "CardAlbumRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsPlay",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsPlay",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsPlay",
                table: "CardTrackRepository",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsPlay",
                table: "CardPlayListRepository",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsPlay",
                table: "CardArtistRepository",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsPlay",
                table: "CardAlbumRepository",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

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

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPlay",
                value: "pause");

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsPlay",
                value: "pause");

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsPlay",
                value: "pause");

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsPlay",
                value: "pause");
        }
    }
}
