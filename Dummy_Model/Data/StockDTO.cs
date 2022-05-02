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
    /// Gets or sets the release date.
    /// </summary>
    /// <value>
    /// The release date.
    /// </value>
    public DateTime ReleaseDate { get; set; }

    /// <summary>
    /// Gets or sets the total share.
    /// </summary>
    /// <value>
    /// The total share.
    /// </value>
    public long TotalShare { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is active.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
    /// </value>
    public bool IsActive { get; set; }

    /// <summary>
    /// Gets or sets the stock sector.
    /// </summary>
    /// <value>
    /// The stock sector.
    /// </value>
    [ForeignKey("StockSectorId")]
    public StockSectorDTO StockSector { get; set; }

}
