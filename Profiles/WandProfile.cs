
using AutoMapper;
using HarryPotterAPI.Models;

namespace HarryPotterAPI.Profiles
{
    public class WandProfile : Profile
    {
      
        public WandProfile()
        {
            CreateMap<WandDTO, WandModel>();
            CreateMap<WandModel, WandDTORead>();
        }
        
    }
}