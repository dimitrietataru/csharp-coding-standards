using AutoMapper;

namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E101.AutoMapper;

public sealed class CodingStandardsAutoMapperProfile : Profile
{
    public CodingStandardsAutoMapperProfile()
    {
////#pragma warning disable IDE0058 // Expression value is never used
        CreateMap<SourceDto, DestinationDto>()
            .ForMember(
                destination => destination.DestinationProperty,
                options => options.MapFrom(source => source.SourceProperty));
////#pragma warning restore IDE0058 // Expression value is never used
    }
}
