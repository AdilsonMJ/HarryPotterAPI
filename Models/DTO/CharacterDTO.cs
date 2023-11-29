using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models.DTO
{
    public record CharacterDTO
    {
        
        [Required(ErrorMessage = "The Name is required")]
        [StringLength(255)]
        public string Name { get; set; }

        [Range(0, 1000)]
        public int? Age { get; set; }

        [Required]
        public bool IsWitcher {get; set;}

        public string? House { get; set; }

         public WandDTO? Wand  {get; set;}

        
    }
}