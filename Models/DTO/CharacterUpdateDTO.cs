using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotterAPI.Models.DTO
{
    public record CharacterUpdateDTO
    {

        [Required(ErrorMessage = "The Name is required")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Age is required")]
        [Range(0, 1000)]
        public int Age { get; set; }

        public string? House { get; set; }

        [Required]
        public bool IsWitcher { get; set; }
    }
}