using AutoMapper;
using ProjBiblio.Domain.Entities;

namespace ProjBiblio.Application.ViewModels.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Autor, AutorViewModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.AutorID))
                .ReverseMap();

            CreateMap<Livro, LivroViewModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.LivroID))
                .ReverseMap();

            CreateMap<CampanhaMarketing, CampanhaMarketingViewModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.CampanhaMarketingID))
                .ReverseMap();
                
            CreateMap<Genero, GeneroViewModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.GeneroID))
                .ReverseMap();    
        }
    }
}