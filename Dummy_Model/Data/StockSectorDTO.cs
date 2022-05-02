using System.ComponentModel.DataAnnotations;

namespace Dummy_Model;

public class StockSectorDTO
{
    public int StockSectorId { get; set; }

    [Required]
    public string Code { get; set; } = null!;

    [Required]
    public string Name { get; set; } = null!;

    public DateTime ReleaseDate { get; set; }

    public long TotalShare { get; set; }
}
