using AutoMapper;
using TemplateMinAPI.Dtos;
using TemplateMinAPI.Models;

namespace TemplateMinAPI.Profiles
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
            // Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}