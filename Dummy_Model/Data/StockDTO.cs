using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dummy_Model;

public class StockDTO
{
    /// <summary>
    /// Gets or sets the stock identifier.
    /// </summary>
    /// <value>
    /// The stock identifier.
    /// </value>
    public long StockId { get; set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>
    /// The code.
    /// </value>
    [Required]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the stock sector identifier.
    /// </summary>
    /// <value>
    /// The stock sector identifier.
    /// </value>
    public int StockSectorId { get; set; }
    /// <summary>
    /// Gets or sets the stock sector.
    /// </summary>
    /// <value>
    /// The stock sector.
    /// </value>
    [ForeignKey("StockSectorId")]
    public StockSectorDTO StockSector { get; set; }
}
