using Dummy_Repository.Repository.IRepository.Llblgen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy_Repository.Repository.Llblgen
{
    public class DummyLlblgenRepository:    IDummyLlblgenRepository
    {
        public IStockLlblgenRepository Stock { get; }

        public IStockSectorLlblgenRepository Sector { get; }

        public DummyLlblgenRepository()
        {
            Stock = new StockLlblgenRepository(this);
            Sector = new StockSectorLlblgenRepository(this);
        }
    }
}
