using System.ComponentModel.DataAnnotations;

namespace HarryPotterAPI.Models
{
    public class CharacterModel
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Age is required")]
        [Range(0, 1000)]
        public int Age { get; set; }

        [Required]
        public string House { get; set; }


    }
}
