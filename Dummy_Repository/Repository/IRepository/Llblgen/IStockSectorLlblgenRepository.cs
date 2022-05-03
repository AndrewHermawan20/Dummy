using Dummy.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy_Repository.Repository.IRepository.Llblgen
{
    public interface IStockSectorLlblgenRepository
    {
        public Task<StockSectorEntity> Create(StockSectorEntity sector);

        public Task<StockSectorEntity> Update(StockSectorEntity sector);

        public Task<int> Delete(int StockSectorId);

        public Task<StockSectorEntity> GetByStockSectorId(int StockSectorId);

        public Task<IEnumerable<StockSectorEntity>> GetAll();
    }
}
