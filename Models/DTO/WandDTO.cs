using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HarryPotterAPI.Models
{
    public record WandDTO
    {

        [Required]
        [MaxLength(30)]
        public string Wood { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string Core { get; set; }

        [Required]
        [Range(5, 100)]
        public double Size { get; set; }

    }
}