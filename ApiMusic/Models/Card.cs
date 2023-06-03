namespace ApiMusic.Models;
public class Card:ICloneable
{
    public int Id { get; set; }
    public string? Img { get; set; }
    public string? Title { get; set; }
    public string? TypeInformation { get; set; }
    public string? CardFormat { get; set; }
    public int RandomNumber { get; set; }
    public bool IsPlay { get; set; }
    public string? Description { get; set; }
    public bool Underline { get; set; }
    public string? Song { get; set; }
    public TimeSpan Duration { get; set; }

    public object Clone()
    {
        return new Card
        {
            CardFormat = CardFormat,
            Title = Title,
            TypeInformation = TypeInformation,
            Description = Description,
            Id = Id,
            Img = Img,
            Underline = Underline,
            IsPlay = IsPlay,
            RandomNumber = RandomNumber,
            Song = Song,
            Duration = Duration
        };
    }
}
