using AutoMapper;
using CarBook.DTOLayer.DTOs.AboutDTOs;
using CarBook.DTOLayer.DTOs.CarDTOs;
using CarBook.DTOLayer.DTOs.CarFeatureDTOs;
using CarBook.EntityLayer.Concrete;

namespace CarBook.PresentationLayer.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<AboutDTO, About>().ReverseMap();
            CreateMap<CarDTO, Car>().ReverseMap();
            CreateMap<CarFeatureDTO, CarFeature>().ReverseMap();
        }
    }
}