using System;
using System.Collections.Generic;

namespace Dummy_Data.Model
{
    public partial class Configuration
    {
        public int ConfigurationId { get; set; }
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Version { get; set; }
    }
}
