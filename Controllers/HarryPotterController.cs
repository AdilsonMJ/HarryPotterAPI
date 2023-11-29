using AutoMapper;
using HarryPotterAPI.Data;
using HarryPotterAPI.Models;
using HarryPotterAPI.Models.DTO;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HarryPotterAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HarryPotterController : Controller
    {

        private HarryPotterContext _context;
        private IMapper _mapper;

        public HarryPotterController(HarryPotterContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> AddPersonagem([FromBody] CharacterDTO characterDTO)
        {

            CharacterModel characterModel = new CharacterModel
            {
                Name = characterDTO.Name,
                Age = characterDTO.Age,
                IsWitcher = characterDTO.IsWitcher,
                House = characterDTO.House
            };

            WandModel wand = new WandModel
            {
                Wood = characterDTO.Wand.Wood,
                Core = characterDTO.Wand.Core,
                Size = characterDTO.Wand.Size,
                Character = characterModel
            };

            characterModel.Wand = wand;


            await _context.characters.AddAsync(characterModel);
            await _context.SaveChangesAsync();

           // return CreatedAtAction(nameof(getCharacter), new { id = characterModel.id }, characterModel);

            return Ok();
        }


        [HttpGet]
        public async Task<ActionResult<List<CharacterModel>>> GetPersonagens([FromQuery] int skip = 0, [FromQuery] int take = 20)
        {
            return Ok(await _context.characters.Skip(skip).Take(take).Include(c => c.Wand).ToListAsync());
        }


        [HttpGet("{id}")]
        public IActionResult getCharacter(int id)
        {
            var character = _context.characters.FirstOrDefault(characters => characters.id == id);

            if (character == null) return NotFound();
            return Ok(character);
        }


        // HttpPut recive a object to update but need a full object.

        [HttpPut("{id}")]
        public IActionResult UpdateCharacter(int id, [FromBody] CharacterUpdateDTO characterUpdate)
        {
            var character = _context.characters.FirstOrDefault(c => c.id == id);
            if (character == null) return NotFound();

            _mapper.Map(characterUpdate, character);
            _context.SaveChanges();

            return NoContent();

        }


        [HttpPatch("{id}")]
        public IActionResult UpdateCharacterPatch(int id, JsonPatchDocument<CharacterUpdateDTO> patch)
        {
            var character = _context.characters.FirstOrDefault(c => c.id == id);
            if (character == null) return NotFound();

            var characterUpDate = _mapper.Map<CharacterUpdateDTO>(character);

            patch.ApplyTo(characterUpDate, ModelState);

            if (!TryValidateModel(characterUpDate)) return ValidationProblem(ModelState);


            _mapper.Map(characterUpDate, character);
            _context.SaveChanges();
            return NoContent();

        }


    }

}
