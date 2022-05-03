using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy_Repository.Repository.IRepository.Llblgen
{
    public interface IDummyLlblgenRepository
    {
        IStockLlblgenRepository Stock { get; }


        IStockSectorLlblgenRepository Sector { get; }

    }
}
