using System;
using System.Collections.Generic;

namespace Dummy_Data.Model
{
    public partial class Portofolio
    {
        public Portofolio()
        {
            PortofolioItems = new HashSet<PortofolioItem>();
        }

        public int PortofolioId { get; set; }
        public int UserId { get; set; }
        public decimal Value { get; set; }
        public decimal Cash { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<PortofolioItem> PortofolioItems { get; set; }
    }
}
