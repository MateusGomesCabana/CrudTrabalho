using AutoMapper;
using ProjBiblio.Domain.Entities;

namespace ProjBiblio.Application.InputModels.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Autor, AutorInputModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.AutorID))
                .ReverseMap();

            CreateMap<Livro, LivroInputModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.LivroID))
                .ReverseMap();

            CreateMap<CampanhaMarketing, CampanhaMarketingInputModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.CampanhaMarketingID))
                .ReverseMap();

            CreateMap<Genero, GeneroInputModel>()
                .ForMember(dest => dest.Id, 
                           opt => opt.MapFrom(src => src.GeneroID))
                .ReverseMap();    
        }
    }
}