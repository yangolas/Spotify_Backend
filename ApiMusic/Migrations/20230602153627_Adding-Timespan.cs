using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMusic.Migrations
{
    /// <inheritdoc />
    public partial class AddingTimespan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Timespan",
                table: "CardTrackRepository",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Timespan",
                table: "CardPlayListRepository",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Timespan",
                table: "CardArtistRepository",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Timespan",
                table: "CardAlbumRepository",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CardAlbumRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "CardArtistRepository",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "CardPlayListRepository",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 766, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "CardTrackRepository",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timespan",
                value: new DateTime(2023, 6, 2, 17, 36, 27, 767, DateTimeKind.Local).AddTicks(20));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timespan",
                table: "CardTrackRepository");

            migrationBuilder.DropColumn(
                name: "Timespan",
                table: "CardPlayListRepository");

            migrationBuilder.DropColumn(
                name: "Timespan",
                table: "CardArtistRepository");

            migrationBuilder.DropColumn(
                name: "Timespan",
                table: "CardAlbumRepository");
        }
    }
}
