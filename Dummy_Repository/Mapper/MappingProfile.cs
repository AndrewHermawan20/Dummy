using AutoMapper;
using Dummy_Data.Model;
using Dummy_Model;

namespace Dummy_Repository.Mapper;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Stock, StockDTO>().ReverseMap();
        CreateMap<StockSector, StockSectorDTO>().ReverseMap();
    }
}
