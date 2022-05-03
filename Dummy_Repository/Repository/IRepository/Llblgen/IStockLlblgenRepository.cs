using Dummy.EntityClasses;
using Dummy.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy_Repository.Repository.IRepository.Llblgen
{
    public interface IStockLlblgenRepository
    {
        public Task<StockEntity> Create(StockEntity objDTO);

        public Task<StockEntity> Update(StockEntity objDTO);

        public Task<int> Delete(int stockId);

        public Task<StockEntity> GetByStockId(int stockId);

        public Task<IEnumerable<StockEntity>> FetchEntities();
    }
}
