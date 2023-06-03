using ApiMusic.Models;

namespace ApiMusic.Service;

public interface ISectionService
{
    Task<IEnumerable<Section>> GetInitSections();

}
