using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities.DataEntities;

public class InformationMusicRepositoryData
{
    public static void SetData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InformationMusicRepository>()
            .HasData(
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 1,
                    Img = "https://cdn.shopify.com/s/files/1/0013/2802/1548/products/David-Guetta-_-Bebe-Rexha---I_m-Good-_Ableton-Remake_360x.png?v=1662741948",
                    Name = "I'm Good(Blue)",
                    Song = "Im good.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 2,
                    Img = "https://m.media-amazon.com/images/I/51l8ywMOKBL._UX358_FMwebp_QL85_.jpg",
                    Name = "Crazy What Love Can Do",
                    Song = "Crazy What Love Can Do.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 3,
                    Img = "https://cdn.shopify.com/s/files/1/0013/2802/1548/products/David-Guetta-_-Bebe-Rexha---I_m-Good-_Ableton-Remake_360x.png?v=1662741948",
                    Name = "I'm Good(Blue)",
                    Song = "Crazy What Love Can Do.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 4,
                    Img = "https://m.media-amazon.com/images/I/41ujS0zVpKL._UX358_FMwebp_QL85_.jpg",
                    Name = "Don´t you worry",
                    Song = "DONT YOU WORRY.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 5,
                    Img = "https://e-cdn-images.dzcdn.net/images/cover/966d3b06e478335d2a8766cba9ab5241/264x264-000000-80-0-0.jpg",
                    Name = "Love Tonight",
                    Song = "Love Tonight.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "Armin Van Buuren",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 6,
                    Img = "https://los40es00.epimg.net/los40/imagenes/los40dance/2018/07/N%C2%BA1-Armin-Van-Buuren-Blah-Blah-Blah-Maxima-51-Chart.jpg",
                    Name = "Blah Blah Blah",
                    Song = "Blah Blah Blah.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "Patrizienta",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 7,
                    Img = "https://localhost:7250/api/Image/Patri.jpg",
                    Name = "This is what it feels like",
                    Song = "This is what it feels like.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "Patrizienta",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 8,
                    Img = "https://localhost:7250/api/Image/Patri.jpg",
                    Name = "Great Spirit",
                    Song = "Great Spirit.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "Patrizienta",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 9,
                    Img = "https://localhost:7250/api/Image/Patri.jpg",
                    Name = "Leave A Little Love",
                    Song = "Leave A Little Love.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "Patrizienta",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 10,
                    Img = "https://localhost:7250/api/Image/Patri.jpg",
                    Name = "GIRL LIKE ME",
                    Song = "GIRL LIKE ME.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "Patrizienta",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 11,
                    Img = "https://localhost:7250/api/Image/Patri.jpg",
                    Name = "Te Felicito",
                    Song = "Te Felicito.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "Patrizienta",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 12,
                    Img = "https://localhost:7250/api/Image/Patri.jpg",
                    Song = "Waka Waka This Time for Africa.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "Patrizienta",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 13,
                    Img = "https://localhost:7250/api/Image/Patri.jpg",
                    Name = "La Bicicleta",
                    Song = "La Bicicleta.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "Natos y waor",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 14,
                    Img = "https://www.azlyrics.com/images/albums/112/ed8f1265141816d14948c740f30c6a51.jpg",
                    Name = "Rumba",
                    Song = "Rumba.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 15,
                    Img = "https://lastfm.freetls.fastly.net/i/u/ar0/721c6a8f77c4076b0249589950c5c8e5.jpg",
                    Name = "Sudores Fríos",
                    Song = "Sudores Fríos.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "Natos y waor",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 16,
                    Img = "https://www.azlyrics.com/images/albums/112/ed8f1265141816d14948c740f30c6a51.jpg",
                    Name = "Hasta que salga el sol",
                    Song = "Hasta que salga el sol.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 17,
                    Img = "https://www.azlyrics.com/images/albums/112/ed8f1265141816d14948c740f30c6a51.jpg",
                    Name = "Vale tudo",
                    Song = "Vale tudo.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 18,
                    Img = "https://upload.wikimedia.org/wikipedia/en/thumb/d/df/Arctic_Monkeys_-_Do_I_Wanna_Know.png/220px-Arctic_Monkeys_-_Do_I_Wanna_Know.png",
                    Name = "Do I Wanna Know",
                    Song = "Do I Wanna Know.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 19,
                    Img = "https://2.bp.blogspot.com/-y_69ZYHLDkk/XHRy-MwLcNI/AAAAAAAAAP0/XWYIVVPBAwY_Y2lzHDk1OSXdPf6lADD4QCLcBGAs/s320/arctic-monkeys-am-artwork.jpg",
                    Name = "I Wanna Be Yours",
                    Song = "I Wanna Be Yours.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 20,
                    Img = "https://cdn11.bigcommerce.com/s-bnr350xzri/images/stencil/640w/products/21378/21633/SLPTVNYL6508__86367.1567870887.jpg?c=2",
                    Name = "505",
                    Song = "505.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 21,
                    Img = "data:image/png;base64,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",
                    Name = "Whyd you only call me when youre high",
                    Song = "Whyd you only call me when youre high.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 22,
                    Img = "https://239.d98.mwp.accessdomain.com/wp-content/uploads/2020/12/the-strokes-nuevo-video-the-adults-are-talking-2020.jpeg",
                    Name = "The Adults Are Talking",
                    Song = "The Adults Are Talking.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 23,
                    Img = "https://m.media-amazon.com/images/I/81FmHlCuy+L._SX425_.jpg",
                    Name = "Reptilia",
                    Song = "Reptilia.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 24,
                    Img = "https://upload.wikimedia.org/wikipedia/en/2/22/The_Strokes_-_Last_Nite_-_CD_single_cover.jpg?20160118161407",
                    Name = "Last Nite",
                    Song = "Last Nite.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 25,
                    Img = "https://preview.redd.it/b5qjg8331qe11.jpg?width=960&crop=smart&auto=webp&s=2ad1fe90539eddbf4709bde77db625f0757537ca",
                    Name = "You Only Live Once",
                    Song = "You Only Live Once.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 26,
                    Img = "https://upload.wikimedia.org/wikipedia/en/thumb/6/68/Dover_Devil_Came_to_Me.jpg/220px-Dover_Devil_Came_to_Me.jpg",
                    Name = "Devil came to me",
                    Song = "Devil came to me.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 27,
                    Img = "https://m.media-amazon.com/images/I/41FBZWH1QFL.jpg",
                    Name = "King George",
                    Song = "King George.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 28,
                    Img = "https://soycantante.es/wp-content/uploads/2019/06/481.jpg",
                    Name = "Let me out",
                    Song = "Let me out.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 29,
                    Img = "https://i.ytimg.com/vi/GQbytKkt0tg/maxresdefault.jpg",
                    Name = "Serenade",
                    Song = "Serenade.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 30,
                    Img = "https://images.genius.com/eff5f07e881df0a6d84292d42eed235a.1000x1000x1.jpg",
                    Name = "Ancha Es Castilla",
                    Song = "Ancha Es Castilla.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 31,
                    Img = "https://www.mautorland.com/wp-content/uploads/2019/01/AB322DA7-C965-42A0-B3AB-474D475E868B-e1547135117468.jpeg",
                    Name = "Fiesta Pagana",
                    Song = "Fiesta Pagana.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 32,
                    Img = "https://i.ytimg.com/vi/_wLa8ck3SEo/maxresdefault.jpg",
                    Name = "TEsnucare",
                    Song = "TEsnucare.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 33,
                    Img = "https://nikkur.ru/wp-content/uploads/2021/06/dvrst.jpg",
                    Name = "CLOSE EYES",
                    Song = "CLOSE EYES.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 34,
                    Img = "https://a10.gaanacdn.com/gn_img/albums/6Zxb27K9wN/xb2rJxZob9/size_m.jpg",
                    Name = "Dream Space",
                    Song = "Dream Space.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 35,
                    Img = "https://m.media-amazon.com/images/I/31E8+bpkk7L._SX354_SY354_BL0_QL100__UXNaN_FMjpg_QL85_.jpg",
                    Name = "SHE IS HYPERACTIVE",
                    Song = "SHE IS HYPERACTIVE.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 36,
                    Img = "https://m.media-amazon.com/images/I/31F7SEJj+nL._SX354_SY354_BL0_QL100__UXNaN_FMjpg_QL85_.jpg",
                    Name = "Always Want Me",
                    Song = "Always Want Me.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 37,
                    Img = "https://m.media-amazon.com/images/I/71bjgWhwaaL._SX425_.jpg",
                    Name = "Beat It",
                    Song = "Beat It.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 38,
                    Img = "http://www.eloriente.net/home/wp-content/uploads/2014/06/michael-jackson-billie-jean.jpg",
                    Name = "Billie Jean",
                    Song = "Billie Jean.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 39,
                    Img = "https://upload.wikimedia.org/wikipedia/en/3/36/%22Chicago%22_promotional_cover.jpg",
                    Name = "Chicago",
                    Song = "Chicago.mp3"
                },
                new InformationMusicRepository
                {
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Description = "",
                    Duration = new TimeSpan(0, 2, 0),
                    Id = 40,
                    Img = "https://m.media-amazon.com/images/I/711s0ldO7RL._SY355_.jpg",
                    Name = "Smooth Criminal",
                    Song = "Smooth Criminal.mp3"
                }
            );
    }
}