
using AutoMapper;
using HarryPotterAPI.Models;
using HarryPotterAPI.Models.DTO;

namespace HarryPotterAPI.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<CharacterDTO, CharacterModel>();
            CreateMap<CharacterUpdateDTO, CharacterModel>();
            CreateMap<CharacterModel, CharacterUpdateDTO>();
        }
    }
}