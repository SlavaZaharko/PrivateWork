using AutoMapper;
using PrivateWork.API.Models;
using PrivateWork.API.Models.Input;
using PrivateWork.API.Models.OutputModel;
using PrivateWork.Core;
using PrivateWork.Data.Dto;
using System;

namespace PrivateWork.API.Configuration
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<OrderDto, OrderOutputModel>()
                .ForPath(dest => dest.City, o => o.MapFrom(src => src.City.Name))
                .ForPath(dest => dest.Date, o => o.MapFrom(src => src.Date.ToString("dd.MM.yyyy HH:mm:ss")))
                .ForPath(dest => dest.OrderInfos, o => o.MapFrom(src => src.OrderInfos));

            CreateMap<OrderInfoDto, OrderInfoOutputModel>()
                .ForPath(dest => dest.ProductId, o => o.MapFrom(src => src.Product.Id))
                .ForPath(dest => dest.Name, o => o.MapFrom(src => src.Product.Name))
                .ForPath(dest => dest.Producer, o => o.MapFrom(src => src.Product.Producer));

            CreateMap<ProductDto, ProductGeneralOutputModel>()
                .ForPath(dest => dest.Category, o => o.MapFrom(src => Enum.GetName(typeof(Category), src.CategoryId)));

            CreateMap<ProductInputModel, ProductDto>();


        }
    }
}
