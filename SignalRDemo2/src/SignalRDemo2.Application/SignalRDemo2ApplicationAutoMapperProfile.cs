using AutoMapper;
using SignalRDemo;

namespace SignalRDemo2;

public class SignalRDemo2ApplicationAutoMapperProfile : Profile
{
    public SignalRDemo2ApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<SignalRTest, SignalRTestDto>();
    }
}
