using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source to Target
            CreateMap<Command, CommandReadDto>();
            // Target to Source
            CreateMap<CommandCreateDto, Command>();
        }
    }
}
