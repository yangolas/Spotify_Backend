using ApiMusic.Models;
using Commons;
using System.Text.RegularExpressions;

namespace ApiMusic.Mocks;

public static class ListCardsMock
{
    public static List<Card> Get()
        => new List<Card>()
        {
             new Card()
            {
                Id = 1,
                CardFormat = CardFormat.basic.ToString(),
                Description = "La Virgen",
                Img = "https://localhost:7250/api/image/Choto.jpg",
                IsPlay = false,
                RandomNumber = 0,
                Title = "La Virgen",
                TypeInformation = TypeInformation.album.ToString(),
                Underline = false,
                Song = "Chicago.mp3"
            },
            new Card()
            {
                Id = 2,
                CardFormat = CardFormat.basic.ToString(),
                Description = "David Guetta",
                Img = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/9fc5200a-b94d-4753-ac39-e98e7c9377f0/d8vhdjz-8c3a59a7-255e-4031-83ca-2056b9d17a17.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzlmYzUyMDBhLWI5NGQtNDc1My1hYzM5LWU5OGU3YzkzNzdmMFwvZDh2aGRqei04YzNhNTlhNy0yNTVlLTQwMzEtODNjYS0yMDU2YjlkMTdhMTcuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.KHtICShMnLtqo-bGALdzRz0HRDAnQjWAyJVKkqbARDs",
                IsPlay = false,
                RandomNumber = 1,
                Title = "David Guetta",
                TypeInformation = TypeInformation.artist.ToString(),
                Underline = false,
                Song = "Always Want Me.mp3"
            },
            new Card()
            {
                Id = 3,
                CardFormat = CardFormat.basic.ToString(),
                Description = "I'm Good(Blue)",
                Img = "https://cdn.shopify.com/s/files/1/0013/2802/1548/products/David-Guetta-_-Bebe-Rexha---I_m-Good-_Ableton-Remake_360x.png?v=1662741948",
                IsPlay = false,
                RandomNumber = 2,
                Title = "I'm Good(Blue)",
                TypeInformation = TypeInformation.track.ToString(),
                Underline = false,
                Song = "Blah Blah Blah.mp3"
            },
            new Card()
            {
                Id = 4,
                CardFormat = CardFormat.basic.ToString(),
                Description = "Rumba",
                Img = "https://www.azlyrics.com/images/albums/112/ed8f1265141816d14948c740f30c6a51.jpg",
                IsPlay = false,
                RandomNumber = 3,
                Title = "Rumba",
                TypeInformation = TypeInformation.track.ToString(),
                Underline = false,
                Song = "Rumba.mp3"
            },
            new Card()
            {
                Id = 5,
                CardFormat = CardFormat.basic.ToString(),
                Description = "Armin Van Buuren",
                Img = "https://onecms-res.cloudinary.com/image/upload/s--_A0VQVVp--/c_crop,h_774,w_1033,x_15,y_218/c_fill,g_auto,h_523,w_693/f_auto,q_auto/v1/mediacorp/cna/image/2022/08/18/zo22_armin.jpg?itok=zHe4UbVG",
                IsPlay = false,
                RandomNumber = 4,
                Title = "Armin Van Buuren",
                TypeInformation = TypeInformation.artist.ToString(),
                Underline = false,
                Song = "CLOSE EYES.mp3"
            },
            new Card()
            {
                Id = 6,
                CardFormat = CardFormat.basic.ToString(),
                Description = "Zelda",
                Img = "https://i.blogs.es/194fd5/legend-zelda-breath-wild-nintendo-switch-impresiones/1366_2000.webp",
                IsPlay = false,
                RandomNumber = 5,
                Title = "Zelda",
                TypeInformation = TypeInformation.artist.ToString(),
                Underline = false,
                Song = "La Leyenda De La Mancha.mp3"
            }
        };

    public static List<Card> GetNoBasic()
        => new List<Card>()
        {
             new Card()
            {
                Id = 1,
                CardFormat = CardFormat.blog.ToString(),
                Description = "La Virgen",
                Img = "https://localhost:7250/api/image/Choto.jpg",
                IsPlay = false,
                RandomNumber = 0,
                Title = "La Virgen",
                TypeInformation = TypeInformation.album.ToString(),
                Underline = false,
                Song = "Chicago.mp3"
            },
            new Card()
            {
                Id = 2,
                CardFormat = CardFormat.circle.ToString(),
                Description = "David Guetta",
                Img = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/9fc5200a-b94d-4753-ac39-e98e7c9377f0/d8vhdjz-8c3a59a7-255e-4031-83ca-2056b9d17a17.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzlmYzUyMDBhLWI5NGQtNDc1My1hYzM5LWU5OGU3YzkzNzdmMFwvZDh2aGRqei04YzNhNTlhNy0yNTVlLTQwMzEtODNjYS0yMDU2YjlkMTdhMTcuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.KHtICShMnLtqo-bGALdzRz0HRDAnQjWAyJVKkqbARDs",
                IsPlay = false,
                RandomNumber = 1,
                Title = "David Guetta",
                TypeInformation = TypeInformation.artist.ToString(),
                Underline = false,
                Song = "Always Want Me.mp3"
            },
            new Card()
            {
                Id = 3,
                CardFormat = CardFormat.blogUnderline.ToString(),
                Description = "I'm Good(Blue)",
                Img = "https://cdn.shopify.com/s/files/1/0013/2802/1548/products/David-Guetta-_-Bebe-Rexha---I_m-Good-_Ableton-Remake_360x.png?v=1662741948",
                IsPlay = false,
                RandomNumber = 2,
                Title = "I'm Good(Blue)",
                TypeInformation = TypeInformation.track.ToString(),
                Underline = false,
                Song = "Blah Blah Blah.mp3"
            },
            new Card()
            {
                Id = 4,
                CardFormat = CardFormat.blog.ToString(),
                Description = "Rumba",
                Img = "https://www.azlyrics.com/images/albums/112/ed8f1265141816d14948c740f30c6a51.jpg",
                IsPlay = false,
                RandomNumber = 3,
                Title = "Rumba",
                TypeInformation = TypeInformation.track.ToString(),
                Underline = false,
                Song = "Rumba.mp3"
            },
            new Card()
            {
                Id = 5,
                CardFormat = CardFormat.circle.ToString(),
                Description = "Armin Van Buuren",
                Img = "https://onecms-res.cloudinary.com/image/upload/s--_A0VQVVp--/c_crop,h_774,w_1033,x_15,y_218/c_fill,g_auto,h_523,w_693/f_auto,q_auto/v1/mediacorp/cna/image/2022/08/18/zo22_armin.jpg?itok=zHe4UbVG",
                IsPlay = false,
                RandomNumber = 4,
                Title = "Armin Van Buuren",
                TypeInformation = TypeInformation.artist.ToString(),
                Underline = false,
                Song = "CLOSE EYES.mp3"
            },
            new Card()
            {
                Id = 6,
                CardFormat = CardFormat.blogUnderline.ToString(),
                Description = "Zelda",
                Img = "https://i.blogs.es/194fd5/legend-zelda-breath-wild-nintendo-switch-impresiones/1366_2000.webp",
                IsPlay = false,
                RandomNumber = 5,
                Title = "Zelda",
                TypeInformation = TypeInformation.artist.ToString(),
                Underline = false,
                Song = "La Leyenda De La Mancha.mp3"
            },
            new Card()
            {
                Id = 7,
                CardFormat = CardFormat.circle.ToString(),
                Description = "Zeci",
                Img = "https://www.thepocketmagazine.com/wp-content/uploads/2021/06/Captura-de-pantalla-2021-06-14-a-las-11.57.35.png",
                IsPlay = false,
                RandomNumber = 6,
                Title = "Zeci",
                TypeInformation = TypeInformation.artist.ToString(),
                Underline = false,
                Song = "Fiesta Pagana.mp3"
            },
            new Card()
            {
                Id = 8,
                CardFormat = CardFormat.circle.ToString(),
                Description = "Artic Monkeys",
                Img = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/9fc5200a-b94d-4753-ac39-e98e7c9377f0/d8vhdjz-8c3a59a7-255e-4031-83ca-2056b9d17a17.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzlmYzUyMDBhLWI5NGQtNDc1My1hYzM5LWU5OGU3YzkzNzdmMFwvZDh2aGRqei04YzNhNTlhNy0yNTVlLTQwMzEtODNjYS0yMDU2YjlkMTdhMTcuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.KHtICShMnLtqo-bGALdzRz0HRDAnQjWAyJVKkqbARDs",
                IsPlay = false,
                RandomNumber = 7,
                Title = "Artic Monkeys",
                TypeInformation = TypeInformation.artist.ToString(),
                Underline = false,
                Song = "I Wanna Be Yours.mp3"
            },
            new Card()
            {
                Id = 9,
                CardFormat = CardFormat.blog.ToString(),
                Description = "Patrizienta 👸💕",
                Img = "https://localhost:7250/api/image/Patri.jpg",
                IsPlay = false,
                RandomNumber = 8,
                Title = "Patrizienta 👸💕",
                TypeInformation = TypeInformation.artist.ToString(),
                Underline = false,
                Song = "La Bicicleta.mp3"
            },
            new Card()
            {
                Id = 10,
                CardFormat = CardFormat.blogUnderline.ToString(),
                Description = "Sudores Fríos",
                Img = "https://lastfm.freetls.fastly.net/i/u/ar0/721c6a8f77c4076b0249589950c5c8e5.jpg",
                IsPlay = false,
                RandomNumber = 9,
                Title = "Sudores Fríos",
                TypeInformation = TypeInformation.track.ToString(),
                Underline = false,
                Song = "Hasta que salga el sol.mp3"
            },
        };
}
