using ApiMusic.Mocks;
using ApiMusic.Models;
using ApiMusic.Service;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly ISectionService _sectionService;
        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }
        // GET: api/<SectionController>
        [HttpGet]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IList<Section>))]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Section> sections = await _sectionService.GetInitSections();
            return Ok(new {sections = sections});            
        }
    }
}
