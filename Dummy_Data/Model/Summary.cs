using System;
using System.Collections.Generic;

namespace Dummy_Data.Model
{
    public partial class Summary
    {
        public long SummaryId { get; set; }
        public DateTime SummaryDate { get; set; }
        public int UserId { get; set; }
        public decimal? TotalBuyNetAmount { get; set; }
        public decimal? TotalSellNetAmount { get; set; }
        public decimal? MateraiFee { get; set; }
        public decimal? Deviden { get; set; }
        public decimal? LoanInterest { get; set; }
        public decimal? CapitalGain { get; set; }
        public decimal? CapitalLoss { get; set; }
        public decimal? Transfer { get; set; }
        public decimal? Withdraw { get; set; }
        public decimal? CurrentCash { get; set; }
        public decimal? AdjustmentCurrentCash { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Version { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
