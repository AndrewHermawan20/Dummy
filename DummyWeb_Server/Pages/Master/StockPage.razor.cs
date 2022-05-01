using Dummy_Model;

namespace DummyWeb_Server.Pages;

public partial class StockPage
{
    private IEnumerable<StockDTO> Stocks { get; set; } = new List<StockDTO>();

    private IEnumerable<StockSectorDTO> Sectors { get; set; } = new List<StockSectorDTO>();

    private StockDTO Stock { get; set; } = new StockDTO();

    private Modal modal { get; set; } = new Modal();

    protected override async Task OnInitializedAsync()
    {
        IsVisibleModalSpinner = true;
        StateHasChanged();
        await FetchStock();
        await FetchStockSector();

        if (Stocks.Count() != 0)
        {
            IsVisibleModalSpinner = false;
            StateHasChanged();
        }
    }

    private async Task FetchStock()
    {
        try
        {
            Stocks = await Repository.Stock.GetAll();
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await SweetAlertFailure(ex.ToString());
        }
    }
    private async Task FetchStockSector()
    {
        try
        {
            Sectors = await Repository.StockSector.GetAll();
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await SweetAlertFailure(ex.ToString());
        }
    }

    #region Create

    /// <summary>
    /// Creates this instance.
    /// </summary>
    public async Task Create()
    {
        try
        {
            if (string.IsNullOrWhiteSpace(Stock.Name) || string.IsNullOrWhiteSpace(Stock.Code) || Stock.StockSectorId.Equals(null))
            {
                await SweetAlertWarning("Terdapat data yang kosong!");
                return;
            }

            await Repository.Stock.Create(Stock);

            await SweetAlertSuccess();
            await FetchStock();
            IsVisibleModalCreate = false;
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await SweetAlertFailure(ex.ToString());
        }
    }

    #endregion Create

    #region Edit

    /// <summary>
    /// Fetches the stock sector by identifier.
    /// </summary>
    /// <param name="entityId">The entity identifier.</param>
    private async Task FetchStockSectorById(int entityId)
    {
        try
        {
            IsVisibleModalEdit = true;
            Stock = new StockDTO();
            Stock = await Repository.Stock.GetByStockId(entityId);

            StateHasChanged();
        }
        catch (Exception ex)
        {
            await SweetAlertFailure(ex.ToString());
        }
    }

    /// <summary>
    /// Updates the stock sector.
    /// </summary>
    /// <param name="entityId">The entity identifier.</param>
    private async Task Update()
    {
        try
        {
            await Repository.Stock.Update(Stock);

            await SweetAlertSuccess();
            await FetchStock();
            IsVisibleModalEdit = false;
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await SweetAlertFailure(ex.ToString());
        }
    }

    #endregion Edit

    #region Delete

    private async Task FetchForDelete(StockDTO stock)
    {
        try
        {
            IsVisibleModalDelete = true;
            Stock = stock;
            Stock = await Repository.Stock.GetByStockId(stock.StockId);
        }
        catch (Exception ex)
        {
            await SweetAlertFailure(ex.ToString());
        }
    }

    private async Task Delete(long stockId)
    {
        try
        {
            await Repository.Stock.Delete(stockId);

            await SweetAlertSuccess();
            await FetchStock();
            IsVisibleModalDelete = false;
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await SweetAlertFailure(ex.ToString());
        }
    }

    #endregion Delete
}
