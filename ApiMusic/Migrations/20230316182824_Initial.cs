using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiMusic.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardAlbumRepository",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardAlbumRepository", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardArtistRepository",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardArtistRepository", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardPlayListRepository",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardPlayListRepository", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformationMusicRepository",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Song = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationMusicRepository", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardTrackRepository",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardAlbumRepositoryId = table.Column<int>(type: "int", nullable: true),
                    CardArtistRepositoryId = table.Column<int>(type: "int", nullable: true),
                    CardPlayListRepositoryId = table.Column<int>(type: "int", nullable: true),
                    InformationMusicRepositoryId = table.Column<int>(type: "int", nullable: false),
                    IsPlay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardTrackRepository", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardTrackRepository_CardAlbumRepository_CardAlbumRepositoryId",
                        column: x => x.CardAlbumRepositoryId,
                        principalTable: "CardAlbumRepository",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardTrackRepository_CardArtistRepository_CardArtistRepositoryId",
                        column: x => x.CardArtistRepositoryId,
                        principalTable: "CardArtistRepository",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardTrackRepository_CardPlayListRepository_CardPlayListRepositoryId",
                        column: x => x.CardPlayListRepositoryId,
                        principalTable: "CardPlayListRepository",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardTrackRepository_InformationMusicRepository_InformationMusicRepositoryId",
                        column: x => x.InformationMusicRepositoryId,
                        principalTable: "InformationMusicRepository",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CardAlbumRepository",
                columns: new[] { "Id", "Description", "Img", "Name" },
                values: new object[] { 1, "Natos y Waor", "https://www.azlyrics.com/images/albums/112/ed8f1265141816d14948c740f30c6a51.jpg", "Luna Llena" });

            migrationBuilder.InsertData(
                table: "CardArtistRepository",
                columns: new[] { "Id", "Description", "Img", "Name" },
                values: new object[,]
                {
                    { 1, "Artist", "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/9fc5200a-b94d-4753-ac39-e98e7c9377f0/d8vhdjz-8c3a59a7-255e-4031-83ca-2056b9d17a17.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzlmYzUyMDBhLWI5NGQtNDc1My1hYzM5LWU5OGU3YzkzNzdmMFwvZDh2aGRqei04YzNhNTlhNy0yNTVlLTQwMzEtODNjYS0yMDU2YjlkMTdhMTcuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.KHtICShMnLtqo-bGALdzRz0HRDAnQjWAyJVKkqbARDs", "David Guetta" },
                    { 2, "Artist", "https://onecms-res.cloudinary.com/image/upload/s--_A0VQVVp--/c_crop,h_774,w_1033,x_15,y_218/c_fill,g_auto,h_523,w_693/f_auto,q_auto/v1/mediacorp/cna/image/2022/08/18/zo22_armin.jpg?itok=zHe4UbVG", "Armin Van Buuren" },
                    { 3, "Artist", "Patri.jpg", "Patrizienta 👸💕" },
                    { 4, "Artist", "https://www.wag1mag.com/wp-content/uploads/natos-y-waor-icaro-wag1mag.jpg", "Natos y Waor" },
                    { 5, "Artist", "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/9fc5200a-b94d-4753-ac39-e98e7c9377f0/d8vhdjz-8c3a59a7-255e-4031-83ca-2056b9d17a17.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzlmYzUyMDBhLWI5NGQtNDc1My1hYzM5LWU5OGU3YzkzNzdmMFwvZDh2aGRqei04YzNhNTlhNy0yNTVlLTQwMzEtODNjYS0yMDU2YjlkMTdhMTcuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.KHtICShMnLtqo-bGALdzRz0HRDAnQjWAyJVKkqbARDs", "Artic Monkeys" },
                    { 6, "Artist", "https://onecms-res.cloudinary.com/image/upload/s--_A0VQVVp--/c_crop,h_774,w_1033,x_15,y_218/c_fill,g_auto,h_523,w_693/f_auto,q_auto/v1/mediacorp/cna/image/2022/08/18/zo22_armin.jpg?itok=zHe4UbVG", "The Strokes" },
                    { 7, "Artist", "https://lastfm.freetls.fastly.net/i/u/300x300/afc17efeec086dfeab2ba379fe8fa672.jpg", "Dover" },
                    { 8, "Artist", "https://i.ytimg.com/vi/5jsF-CAcgwE/maxresdefault.jpg", "Mägo de Oz" },
                    { 9, "Artist", "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/9fc5200a-b94d-4753-ac39-e98e7c9377f0/d8vhdjz-8c3a59a7-255e-4031-83ca-2056b9d17a17.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzlmYzUyMDBhLWI5NGQtNDc1My1hYzM5LWU5OGU3YzkzNzdmMFwvZDh2aGRqei04YzNhNTlhNy0yNTVlLTQwMzEtODNjYS0yMDU2YjlkMTdhMTcuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.KHtICShMnLtqo-bGALdzRz0HRDAnQjWAyJVKkqbARDs", "DVRST" },
                    { 10, "Artist", "https://onecms-res.cloudinary.com/image/upload/s--_A0VQVVp--/c_crop,h_774,w_1033,x_15,y_218/c_fill,g_auto,h_523,w_693/f_auto,q_auto/v1/mediacorp/cna/image/2022/08/18/zo22_armin.jpg?itok=zHe4UbVG", "Michael Jackson" }
                });

            migrationBuilder.InsertData(
                table: "CardPlayListRepository",
                columns: new[] { "Id", "Description", "Img", "Name" },
                values: new object[,]
                {
                    { 1, "Artist", "https://i1.sndcdn.com/artworks-000558491658-4v2bd8-t500x500.jpg", "Mix Rock" },
                    { 2, "Artist", "https://www.musicgrotto.com/wp-content/uploads/2021/09/best-songs-of-all-time-graphic-art.jpg", "The Most Heard" },
                    { 3, "Artist", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxDkpIbBPA0JfES8ke5q15Jx_j3FR_0ZrXQw&usqp=CAU", "Super Pop!!" },
                    { 4, "Natos y Waor", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxDkpIbBPA0JfES8ke5q15Jx_j3FR_0ZrXQw&usqp=CAU", "Mix Rap" }
                });

            migrationBuilder.InsertData(
                table: "InformationMusicRepository",
                columns: new[] { "Id", "Description", "Duration", "Img", "Name", "Song" },
                values: new object[,]
                {
                    { 1, "", new TimeSpan(0, 0, 2, 0, 0), "https://cdn.shopify.com/s/files/1/0013/2802/1548/products/David-Guetta-_-Bebe-Rexha---I_m-Good-_Ableton-Remake_360x.png?v=1662741948", "I'm Good(Blue)", "Im good.mp3" },
                    { 2, "", new TimeSpan(0, 0, 2, 0, 0), "https://m.media-amazon.com/images/I/51l8ywMOKBL._UX358_FMwebp_QL85_.jpg", "Crazy What Love Can Do", "Crazy What Love Can Do.mp3" },
                    { 3, "", new TimeSpan(0, 0, 2, 0, 0), "https://cdn.shopify.com/s/files/1/0013/2802/1548/products/David-Guetta-_-Bebe-Rexha---I_m-Good-_Ableton-Remake_360x.png?v=1662741948", "I'm Good(Blue)", "Crazy What Love Can Do.mp3" },
                    { 4, "", new TimeSpan(0, 0, 2, 0, 0), "https://m.media-amazon.com/images/I/41ujS0zVpKL._UX358_FMwebp_QL85_.jpg", "Don´t you worry", "DONT YOU WORRY.mp3" },
                    { 5, "", new TimeSpan(0, 0, 2, 0, 0), "https://e-cdn-images.dzcdn.net/images/cover/966d3b06e478335d2a8766cba9ab5241/264x264-000000-80-0-0.jpg", "Love Tonight", "Love Tonight.mp3" },
                    { 6, "", new TimeSpan(0, 0, 2, 0, 0), "https://los40es00.epimg.net/los40/imagenes/los40dance/2018/07/N%C2%BA1-Armin-Van-Buuren-Blah-Blah-Blah-Maxima-51-Chart.jpg", "Blah Blah Blah", "Blah Blah Blah.mp3" },
                    { 7, "", new TimeSpan(0, 0, 2, 0, 0), "Patri.jpg", "This is what it feels like", "This is what it feels like.mp3" },
                    { 8, "", new TimeSpan(0, 0, 2, 0, 0), "Patri.jpg", "Great Spirit", "Great Spirit.mp3" },
                    { 9, "", new TimeSpan(0, 0, 2, 0, 0), "Patri.jpg", "Leave A Little Love", "Leave A Little Love.mp3" },
                    { 10, "", new TimeSpan(0, 0, 2, 0, 0), "Patri.jpg", "GIRL LIKE ME", "GIRL LIKE ME.mp3" },
                    { 11, "", new TimeSpan(0, 0, 2, 0, 0), "Patri.jpg", "Te Felicito", "Te Felicito.mp3" },
                    { 12, "", new TimeSpan(0, 0, 2, 0, 0), "Patri.jpg", null, "Waka Waka This Time for Africa.mp3" },
                    { 13, "", new TimeSpan(0, 0, 2, 0, 0), "Patri.jpg", "La Bicicleta", "La Bicicleta.mp3" },
                    { 14, "", new TimeSpan(0, 0, 2, 0, 0), "https://www.azlyrics.com/images/albums/112/ed8f1265141816d14948c740f30c6a51.jpg", "Rumba", "Rumba.mp3" },
                    { 15, "", new TimeSpan(0, 0, 2, 0, 0), "https://lastfm.freetls.fastly.net/i/u/ar0/721c6a8f77c4076b0249589950c5c8e5.jpg", "Sudores Fríos", "Sudores Fríos.mp3" },
                    { 16, "", new TimeSpan(0, 0, 2, 0, 0), "https://www.azlyrics.com/images/albums/112/ed8f1265141816d14948c740f30c6a51.jpg", "Hasta que salga el sol", "Hasta que salga el sol.mp3" },
                    { 17, "", new TimeSpan(0, 0, 2, 0, 0), "https://www.azlyrics.com/images/albums/112/ed8f1265141816d14948c740f30c6a51.jpg", "Vale tudo", "Vale tudo.mp3" },
                    { 18, "", new TimeSpan(0, 0, 2, 0, 0), "https://upload.wikimedia.org/wikipedia/en/thumb/d/df/Arctic_Monkeys_-_Do_I_Wanna_Know.png/220px-Arctic_Monkeys_-_Do_I_Wanna_Know.png", "Do I Wanna Know", "Do I Wanna Know.mp3" },
                    { 19, "", new TimeSpan(0, 0, 2, 0, 0), "https://2.bp.blogspot.com/-y_69ZYHLDkk/XHRy-MwLcNI/AAAAAAAAAP0/XWYIVVPBAwY_Y2lzHDk1OSXdPf6lADD4QCLcBGAs/s320/arctic-monkeys-am-artwork.jpg", "I Wanna Be Yours", "I Wanna Be Yours.mp3" },
                    { 20, "", new TimeSpan(0, 0, 2, 0, 0), "https://cdn11.bigcommerce.com/s-bnr350xzri/images/stencil/640w/products/21378/21633/SLPTVNYL6508__86367.1567870887.jpg?c=2", "505", "505.mp3" },
                    { 21, "", new TimeSpan(0, 0, 2, 0, 0), "data:image/png;base64,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", "Whyd you only call me when youre high", "Whyd you only call me when youre high.mp3" },
                    { 22, "", new TimeSpan(0, 0, 2, 0, 0), "https://239.d98.mwp.accessdomain.com/wp-content/uploads/2020/12/the-strokes-nuevo-video-the-adults-are-talking-2020.jpeg", "The Adults Are Talking", "The Adults Are Talking.mp3" },
                    { 23, "", new TimeSpan(0, 0, 2, 0, 0), "https://m.media-amazon.com/images/I/81FmHlCuy+L._SX425_.jpg", "Reptilia", "Reptilia.mp3" },
                    { 24, "", new TimeSpan(0, 0, 2, 0, 0), "https://upload.wikimedia.org/wikipedia/en/2/22/The_Strokes_-_Last_Nite_-_CD_single_cover.jpg?20160118161407", "Last Nite", "Last Nite.mp3" },
                    { 25, "", new TimeSpan(0, 0, 2, 0, 0), "https://preview.redd.it/b5qjg8331qe11.jpg?width=960&crop=smart&auto=webp&s=2ad1fe90539eddbf4709bde77db625f0757537ca", "You Only Live Once", "You Only Live Once.mp3" },
                    { 26, "", new TimeSpan(0, 0, 2, 0, 0), "https://upload.wikimedia.org/wikipedia/en/thumb/6/68/Dover_Devil_Came_to_Me.jpg/220px-Dover_Devil_Came_to_Me.jpg", "Devil came to me", "Devil came to me.mp3" },
                    { 27, "", new TimeSpan(0, 0, 2, 0, 0), "https://m.media-amazon.com/images/I/41FBZWH1QFL.jpg", "King George", "King George.mp3" },
                    { 28, "", new TimeSpan(0, 0, 2, 0, 0), "https://soycantante.es/wp-content/uploads/2019/06/481.jpg", "Let me out", "Let me out.mp3" },
                    { 29, "", new TimeSpan(0, 0, 2, 0, 0), "https://i.ytimg.com/vi/GQbytKkt0tg/maxresdefault.jpg", "Serenade", "Serenade.mp3" },
                    { 30, "", new TimeSpan(0, 0, 2, 0, 0), "https://images.genius.com/eff5f07e881df0a6d84292d42eed235a.1000x1000x1.jpg", "Ancha Es Castilla", "Ancha Es Castilla.mp3" },
                    { 31, "", new TimeSpan(0, 0, 2, 0, 0), "https://www.mautorland.com/wp-content/uploads/2019/01/AB322DA7-C965-42A0-B3AB-474D475E868B-e1547135117468.jpeg", "Fiesta Pagana", "Fiesta Pagana.mp3" },
                    { 32, "", new TimeSpan(0, 0, 2, 0, 0), "https://i.ytimg.com/vi/_wLa8ck3SEo/maxresdefault.jpg", "TEsnucare", "TEsnucare.mp3" },
                    { 33, "", new TimeSpan(0, 0, 2, 0, 0), "https://nikkur.ru/wp-content/uploads/2021/06/dvrst.jpg", "CLOSE EYES", "CLOSE EYES.mp3" },
                    { 34, "", new TimeSpan(0, 0, 2, 0, 0), "https://a10.gaanacdn.com/gn_img/albums/6Zxb27K9wN/xb2rJxZob9/size_m.jpg", "Dream Space", "Dream Space.mp3" },
                    { 35, "", new TimeSpan(0, 0, 2, 0, 0), "https://m.media-amazon.com/images/I/31E8+bpkk7L._SX354_SY354_BL0_QL100__UXNaN_FMjpg_QL85_.jpg", "SHE IS HYPERACTIVE", "SHE IS HYPERACTIVE.mp3" },
                    { 36, "", new TimeSpan(0, 0, 2, 0, 0), "https://m.media-amazon.com/images/I/31F7SEJj+nL._SX354_SY354_BL0_QL100__UXNaN_FMjpg_QL85_.jpg", "Always Want Me", "Always Want Me.mp3" },
                    { 37, "", new TimeSpan(0, 0, 2, 0, 0), "https://m.media-amazon.com/images/I/71bjgWhwaaL._SX425_.jpg", "Beat It", "Beat It.mp3" },
                    { 38, "", new TimeSpan(0, 0, 2, 0, 0), "http://www.eloriente.net/home/wp-content/uploads/2014/06/michael-jackson-billie-jean.jpg", "Billie Jean", "Billie Jean.mp3" },
                    { 39, "", new TimeSpan(0, 0, 2, 0, 0), "https://upload.wikimedia.org/wikipedia/en/3/36/%22Chicago%22_promotional_cover.jpg", "Chicago", "Chicago.mp3" },
                    { 40, "", new TimeSpan(0, 0, 2, 0, 0), "https://m.media-amazon.com/images/I/711s0ldO7RL._SY355_.jpg", "Smooth Criminal", "Smooth Criminal.mp3" }
                });

            migrationBuilder.InsertData(
                table: "CardTrackRepository",
                columns: new[] { "Id", "CardAlbumRepositoryId", "CardArtistRepositoryId", "CardPlayListRepositoryId", "InformationMusicRepositoryId", "IsPlay" },
                values: new object[,]
                {
                    { 1, 1, null, null, 13, "pause" },
                    { 2, null, 3, null, 13, "pause" },
                    { 3, null, null, 3, 13, "pause" },
                    { 4, null, null, null, 13, "pause" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardTrackRepository_CardAlbumRepositoryId",
                table: "CardTrackRepository",
                column: "CardAlbumRepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CardTrackRepository_CardArtistRepositoryId",
                table: "CardTrackRepository",
                column: "CardArtistRepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CardTrackRepository_CardPlayListRepositoryId",
                table: "CardTrackRepository",
                column: "CardPlayListRepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CardTrackRepository_InformationMusicRepositoryId",
                table: "CardTrackRepository",
                column: "InformationMusicRepositoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardTrackRepository");

            migrationBuilder.DropTable(
                name: "CardAlbumRepository");

            migrationBuilder.DropTable(
                name: "CardArtistRepository");

            migrationBuilder.DropTable(
                name: "CardPlayListRepository");

            migrationBuilder.DropTable(
                name: "InformationMusicRepository");
        }
    }
}
