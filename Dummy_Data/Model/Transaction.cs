using System;
using System.Collections.Generic;

namespace Dummy_Data.Model
{
    public partial class Transaction
    {
        public Transaction()
        {
            InverseBuyTransaction = new HashSet<Transaction>();
            InverseSellTransaction = new HashSet<Transaction>();
        }

        public long TransactionId { get; set; }
        public int UserId { get; set; }
        public short TransactionTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int StockId { get; set; }
        public decimal Price { get; set; }
        public long Lot { get; set; }
        public long Shared { get; set; }
        public string GrossAmount { get; set; } = null!;
        public decimal TransactionFee { get; set; }
        public decimal NetAmount { get; set; }
        public bool IsSellFirst { get; set; }
        public long? BuyTransactionId { get; set; }
        public long? SellTransactionId { get; set; }
        public short TransactionStatusId { get; set; }
        public DateTime? CancelDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public long Version { get; set; }

        public virtual Transaction? BuyTransaction { get; set; }
        public virtual Transaction? SellTransaction { get; set; }
        public virtual Stock Stock { get; set; } = null!;
        public virtual TransactionStatus TransactionStatus { get; set; } = null!;
        public virtual TransactionType TransactionType { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Transaction> InverseBuyTransaction { get; set; }
        public virtual ICollection<Transaction> InverseSellTransaction { get; set; }
    }
}
