using System;
using System.Collections.Generic;

namespace Dummy_Data;

public partial class Stock
{
    public int StockId { get; set; }
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public int StockSectorId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual StockSector StockSector { get; set; } = null!;
}
