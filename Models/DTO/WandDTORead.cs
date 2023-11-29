using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HarryPotterAPI.Models
{
    public record WandDTORead
    {


        public int id { get; set; }

        public string Wood { get; set; }
        public string Core { get; set; }

        public double Size { get; set; }

    }
}