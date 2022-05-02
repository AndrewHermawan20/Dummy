using System;
using System.Collections.Generic;

namespace Dummy_Data.Model
{
    public partial class TransactionStatus
    {
        public TransactionStatus()
        {
            Transactions = new HashSet<Transaction>();
        }

        public short TransactionStatusId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int Version { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
