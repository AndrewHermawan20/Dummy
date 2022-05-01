namespace Dummy_Repository.Repository.IRepository;

public interface IDummyRepository
{
    IStockRepository Stock { get; }

    IStockSectorRepository StockSector { get; }

}
