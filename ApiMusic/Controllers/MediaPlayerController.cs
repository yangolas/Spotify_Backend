using ApiMusic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaPlayerController : ControllerBase
    {
        private readonly UploadSettings _uploadSettings;
        private readonly IWebHostEnvironment _enviroment;

        public MediaPlayerController(
            IOptions<UploadSettings> uploadSettings,
            IWebHostEnvironment environment)
        {
            _uploadSettings = uploadSettings.Value;
            _enviroment = environment;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MediaPlayerController>/5
        [HttpGet("{name}")]
        [SwaggerOperation(Summary = "Return Track")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FileStreamResult))]
        public async Task<FileStreamResult> Get(string name)
        {

            string sFile = Path.Combine(
                _enviroment.ContentRootPath,
                _uploadSettings.PathSongs,
                name
            );

            FileStream track = System.IO.File.OpenRead(sFile);

            return File(track, "audio/mp3");
        }

        // POST api/<MediaPlayerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MediaPlayerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MediaPlayerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
