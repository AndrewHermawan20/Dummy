using Dummy.EntityClasses;
using Dummy_Repository.Repository.IRepository.Llblgen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy_Repository.Repository.Llblgen
{
    public class StockLlblgenRepository : IStockLlblgenRepository
    {
        public StockLlblgenRepository(DummyLlblgenRepository repository)
        {

        }
        public Task<StockEntity> Create(StockEntity objDTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int stockId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StockEntity>> FetchEntities()
        {
            throw new NotImplementedException();
        }

        public Task<StockEntity> GetByStockId(int stockId)
        {
            throw new NotImplementedException();
        }

        public Task<StockEntity> Update(StockEntity objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
