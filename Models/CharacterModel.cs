using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HarryPotterAPI.Models
{
    public class CharacterModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; init;} 

        [Required(ErrorMessage = "The Name is required")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Range(0, 1000)]
        public int? Age { get; set; }

        [Required]
        public bool IsWitcher {get; set;}

        public string? House { get; set; }

        public WandModel? Wand  {get; set;}

    }
}
