using HarryPotterAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HarryPotterAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HarryPotterController : Controller
    {

        private static List<CharacterModel> characters = new List<CharacterModel>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AddPersonagem([FromBody] CharacterModel characterModel)
        {
            characterModel.id = id;
            id++;
            characters.Add(characterModel);
            return CreatedAtAction(nameof(getCharacter), new { id = characterModel.id }, characterModel);
        }


        [HttpGet]
        public IEnumerable<CharacterModel> GetPersonagens([FromQuery]int skip = 0, [FromQuery]int take = 20)
        {
            return characters.Skip(skip).Take(take);
        }


        [HttpGet("{id}")]
        public IActionResult getCharacter(int id)
        {
            var character = characters.FirstOrDefault(characters => characters.id == id);

            if (character == null) return NotFound();
            return Ok(character);
        }

    }

}
