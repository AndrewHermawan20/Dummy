using System;
using System.Collections.Generic;

namespace Dummy_Data.Model
{
    public partial class Stock
    {
        public Stock()
        {
            PortofolioItems = new HashSet<PortofolioItem>();
            Transactions = new HashSet<Transaction>();
        }

        public int StockId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int StockSectorId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public long? TotalShare { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual StockSector StockSector { get; set; } = null!;
        public virtual ICollection<PortofolioItem> PortofolioItems { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
