using Dummy.EntityClasses;
using Dummy_Repository.Repository.IRepository.Llblgen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy_Repository.Repository.Llblgen
{
    public class StockSectorLlblgenRepository : IStockSectorLlblgenRepository
    {
        public StockSectorLlblgenRepository(DummyLlblgenRepository repository)
        {

        }
        public Task<StockSectorEntity> Create(StockSectorEntity sector)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int StockSectorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StockSectorEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<StockSectorEntity> GetByStockSectorId(int StockSectorId)
        {
            throw new NotImplementedException();
        }

        public Task<StockSectorEntity> Update(StockSectorEntity sector)
        {
            throw new NotImplementedException();
        }
    }
}
