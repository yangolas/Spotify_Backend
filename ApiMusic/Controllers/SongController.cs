using ApiMusic.Models;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Swashbuckle.AspNetCore.Annotations;
using System.Text;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        // GET: api/<SongController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SongController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("uploads")]
        [SwaggerOperation(Summary = "Upload songs")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Card>))]
        public async Task<IActionResult> Post([FromBody] IEnumerable<Card> cards)
        {
            try 
            { 
                foreach (Card card in cards)
                {
                    string uniqueFileName = $"{Guid.NewGuid().ToString()}-{DateTime.Now.Ticks}.mp3";
                    card.Song = card.Song.Substring(card.Song.IndexOf(',') + 1);
                    Convert.FromBase64String(card.Song);
                    byte[] songBytes = Convert.FromBase64String(card.Song);
                    card.Song = uniqueFileName;
                    string folderPath = Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        $"..\\..\\..\\Assets\\tracks"
                     ); 
                    string filePath = Path.Combine(folderPath, uniqueFileName);
                    await Task.Run(() => System.IO.File.WriteAllBytes(filePath, songBytes));
                }
            }
            catch (Exception ex) 
            { 
                var message = ex.Message.ToString();
            }

            return Ok(cards);
        }

        // PUT api/<SongController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SongController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
