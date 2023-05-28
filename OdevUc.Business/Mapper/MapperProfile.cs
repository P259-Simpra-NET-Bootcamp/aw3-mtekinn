using AutoMapper;
using OdevUc.Business.Category;
using OdevUc.Business.Product;
using OdevUc.Data.Domain;


namespace OdevUc.Business.Mapper;

public class MapperProfile : Profile 
{
    public MapperProfile()
    {
        CreateMap<Data.Domain.Category, CategoryResponse>();
        CreateMap<CategoryRequest, Data.Domain.Category>();

        CreateMap<Data.Domain.Product, ProductResponse>();
        CreateMap<ProductRequest, Data.Domain.Product>();
    }
}
