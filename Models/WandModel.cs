using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HarryPotterAPI.Models
{
    public class WandModel
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}

        [Required]
        [MaxLength(30)]
        public  string? Wood{get; set;}
    
        [Required]
        [MaxLength(30)]
        public  string? Core{get; set;}

        [Required]
        [Range(5, 100)]
        public  double? Size{get; set;}

        public int CharacterId{get; set;}

        [JsonIgnore]
        public CharacterModel? Character{set; get;}

    }
}