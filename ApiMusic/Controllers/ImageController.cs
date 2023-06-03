using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMusic.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ImageController : ControllerBase
{
    // GET api/<ImageController>/5
    [HttpGet("{name}")]
    [SwaggerOperation(Summary = "Return Image")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FileStreamResult))]
    public FileStreamResult GetImage(string name)
    {
        string sFile = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, 
            $"..\\..\\..\\Assets\\img\\{name}"
        );

        FileStream image = System.IO.File.OpenRead(sFile);

        return File(image, "image/jpeg");
    }

    // POST api/<ImageController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ImageController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ImageController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
