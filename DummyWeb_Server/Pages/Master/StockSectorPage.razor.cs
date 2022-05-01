using Dummy_Model;

namespace DummyWeb_Server.Pages
{
    public partial class StockSectorPage
    {
        private IEnumerable<StockSectorDTO> StockSectors { get; set; } = new List<StockSectorDTO>();

        private StockSectorDTO Sector { get; set; } = new StockSectorDTO();

        private Modal modal { get; set; } = new Modal();

        protected override async Task OnInitializedAsync()
        {
            IsVisibleModalSpinner = true;
            StateHasChanged();
            await FetchStockSector();

            if (StockSectors.Count() != 0)
            {
                IsVisibleModalSpinner = false;
                StateHasChanged();
            }
        }

        private async Task FetchStockSector()
        {
            try
            {
                StockSectors = await Repository.StockSector.GetAll();
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
                if (string.IsNullOrWhiteSpace(Sector.Name) || string.IsNullOrWhiteSpace(Sector.Code))
                {
                    await SweetAlertWarning("Terdapat data yang kosong!");
                    return;
                }

                await Repository.StockSector.Create(Sector);

                await SweetAlertSuccess();
                await FetchStockSector();
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
                Sector = new StockSectorDTO();
                Sector = await Repository.StockSector.GetByStockSectorId(entityId);

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
                await Repository.StockSector.Update(Sector);

                await SweetAlertSuccess();
                await FetchStockSector();
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

        private async Task FetchForDelete(StockSectorDTO sector)
        {
            try
            {
                IsVisibleModalDelete = true;
                Sector = sector;
                Sector = await Repository.StockSector.GetByStockSectorId(sector.StockSectorId);
            }
            catch (Exception ex)
            {
                await SweetAlertFailure(ex.ToString());
            }
        }

        private async Task Delete(int sectorId)
        {
            try
            {
                await Repository.StockSector.Delete(sectorId);

                await SweetAlertSuccess();
                await FetchStockSector();
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
}