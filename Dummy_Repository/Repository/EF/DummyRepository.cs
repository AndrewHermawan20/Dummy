using AutoMapper;
using Dummy_Data.Model;
using Dummy_Repository.Repository.IRepository;
using Dummy.Repository;

namespace Dummy_Repository.Repository;
public class DummyRepository : IDummyRepository
{
    public IStockRepository Stock { get; set; }

    public IStockSectorRepository StockSector { get; set; }

    public DummyRepository(DummyContext db, IMapper mapper)
    {
        Stock = new StockRepository(db, mapper);
        StockSector = new StockSectorRepository(db, mapper);
    }


}
