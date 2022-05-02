using System;
using System.Collections.Generic;

namespace Dummy_Data.Model
{
    public partial class StockSector
    {
        public StockSector()
        {
            Stocks = new HashSet<Stock>();
        }

        public int StockSectorId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
