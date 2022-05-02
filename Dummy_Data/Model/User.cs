using System;
using System.Collections.Generic;

namespace Dummy_Data.Model
{
    public partial class User
    {
        public User()
        {
            Portofolios = new HashSet<Portofolio>();
            Summaries = new HashSet<Summary>();
            Transactions = new HashSet<Transaction>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public long Version { get; set; }

        public virtual ICollection<Portofolio> Portofolios { get; set; }
        public virtual ICollection<Summary> Summaries { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
