using HarryPotterAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HarryPotterAPI.Data
{
    public class HarryPotterContext : DbContext
    {

        public HarryPotterContext(DbContextOptions<HarryPotterContext> opts) : base(opts)
        { 


            
        }

        public DbSet<CharacterModel> characters { get; set; }


    }
}
