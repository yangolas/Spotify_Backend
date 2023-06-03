using ApiMusic.Mocks;
using ApiMusic.Models;
using ApiMusic.Service;
using Commons;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using static System.Collections.Specialized.BitVector32;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpGet("{type}/track/{id}")]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IList<Card>))]
        public async Task<IActionResult> GetCardsAssociated(string type, int id)
        {
            TypeInformation enumInfo = Enum.Parse<TypeInformation>(type);
            switch (enumInfo)
            {
                case TypeInformation.album:
                    return Ok(new { cards = await _cardService.GetTracksByAlbum(id) });
                
                case TypeInformation.artist:
                    return Ok(new { cards = await _cardService.GetTracksByArtist(id) });
               
                case TypeInformation.playList:
                    return Ok(new { cards = await _cardService.GetTracksByPlayList(id) });
                
                case TypeInformation.track:
                    return Ok(new { cards = await _cardService.GetTrackByTrack(id) });

                default:
                    return BadRequest();
                
            }
        }

        [HttpGet("{type}/{id}")]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Card))]
        public async Task<IActionResult> GetCard(string type, int id)
        {
            TypeInformation enumInfo = Enum.Parse<TypeInformation>(type);
            switch (enumInfo)
            {
                case TypeInformation.album:
                    return Ok(new { card = await _cardService.GetAlbum(id) });

                case TypeInformation.artist:
                    return Ok(new { card = await _cardService.GetArtist(id) });

                case TypeInformation.playList:
                    return Ok(new { card = await _cardService.GetPlayList(id) });

                case TypeInformation.track:
                    return Ok(new { card = await _cardService.GetTrack(id) });

                default:
                    return BadRequest();

            }
        }

        [HttpGet("{text}")]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IList<Card>))]
        public async Task<IActionResult> GetCardsByText(string text)
        {
            IEnumerable<Card> cards = await _cardService.GetCardsByText(text);
            return Ok(new {cards = cards });
        }

        [HttpPut("{type}/{idFather}/track/{idSon}")]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IActionResult> PutStatusPlayer(string type, int idFather, int idSon)
        {
            TypeInformation enumInfo = Enum.Parse<TypeInformation>(type);
            switch (enumInfo)
            {
                case TypeInformation.album:
                    await _cardService.SetStatusPlayerAlbum(idFather, idSon);
                    break;

                case TypeInformation.artist:
                    await _cardService.SetStatusPlayerArtist(idFather, idSon);
                    break;

                case TypeInformation.playList:
                    await _cardService.SetStatusPlayerPlayList(idFather, idSon);
                    break;
            }

            return Ok(true);
        }


        [HttpPut("track/{id}")]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IActionResult> PutStatusPlayerTrack(int id)
        {
            await _cardService.SetStatusPlayerTrack(id);
            return Ok(true);
        }

        [HttpPost("updatecards")]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IActionResult> PutStatusPlayerTrack([FromBody] List<Card> cards)
        {
            await _cardService.SetCards(cards);
            return Ok(true);
        }

    }
}
