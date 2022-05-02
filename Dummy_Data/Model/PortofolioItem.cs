using System;
using System.Collections.Generic;

namespace Dummy_Data.Model
{
    public partial class PortofolioItem
    {
        public long PortofolioItemId { get; set; }
        public int PortofolioId { get; set; }
        public int StockId { get; set; }
        public long Lot { get; set; }
        public long Shared { get; set; }
        public decimal AverageValue { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public long Version { get; set; }

        public virtual Portofolio Portofolio { get; set; } = null!;
        public virtual Stock Stock { get; set; } = null!;
    }
}
