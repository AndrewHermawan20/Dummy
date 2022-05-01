using Dummy_Model;

namespace Dummy_Repository.Repository.IRepository;
public interface IStockRepository
{
    public Task<StockDTO> Create(StockDTO objDTO);

    public Task<StockDTO> Update(StockDTO objDTO);

    public Task<int> Delete(long stockId);

    public Task<StockDTO> GetByStockId(long stockId);

    public Task<IEnumerable<StockDTO>> GetAll();
}
