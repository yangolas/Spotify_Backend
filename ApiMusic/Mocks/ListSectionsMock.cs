using ApiMusic.Models;
using Commons;

namespace ApiMusic.Mocks
{
    public class ListSectionsMock
    {
        public static IEnumerable<Section> Get()
            => new List<Section>()
            {
                new Section()
                {
                    Id = 1,
                    Title = "Title",
                    TitleSize = SectionTitleSize.big.ToString(),
                    Format = SectionFormat.multipleRows.ToString(),
                    Cards = ListCardsMock.Get()
                },
                new Section()
                {
                    Id = 2,
                    Title = "Title 2",
                    TitleSize = SectionTitleSize.smallViewAll.ToString(),
                    Format = SectionFormat.oneRow.ToString(),
                    Cards = ListCardsMock.GetNoBasic()
                },
                new Section()
                {
                    Id = 3,
                    Title = "Title 3",
                    TitleSize = SectionTitleSize.small.ToString(),
                    Format = SectionFormat.multipleRowsCustomColumns.ToString(),
                    Cards = ListCardsMock.GetNoBasic()
                }
            };
    }
}
