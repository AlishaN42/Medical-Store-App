using AutoMapper;
using Medical.Products;

namespace Medical;

public class MedicalApplicationAutoMapperProfile : Profile
{
    public MedicalApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Product, ProductDto>();
        CreateMap<CreateUpdateProductDto, Product>();
        CreateMap<ProductDto, CreateUpdateProductDto>();
    }
}
