using AutoMapper;

namespace Net6.with.MongoDB.Demo.Models;

public class MappingConfigs : Profile
{
    public MappingConfigs()
    {
        CreateMap<CreateBookDto, Book>().ReverseMap();
        CreateMap<UpdateBookDto, Book>()
            .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
            .ReverseMap();
    }
}
