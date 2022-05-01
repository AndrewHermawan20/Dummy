using Dummy_Model;

namespace Dummy_Repository.Repository.IRepository;

public interface IStockSectorRepository
{
    public Task<StockSectorDTO> Create(StockSectorDTO objDTO);

    public Task<StockSectorDTO> Update(StockSectorDTO objDTO);

    public Task<int> Delete(int StockSectorId);

    public Task<StockSectorDTO> GetByStockSectorId(int StockSectorId);

    public Task<IEnumerable<StockSectorDTO>> GetAll();

}
