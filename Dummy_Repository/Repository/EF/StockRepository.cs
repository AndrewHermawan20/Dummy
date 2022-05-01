using AutoMapper;
using Dummy_Data;
using Dummy_Model;
using Dummy_Data.Model;
using Microsoft.EntityFrameworkCore;
using Dummy_Repository.Repository.IRepository;

namespace Dummy.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly DummyContext _db;
        private readonly IMapper _mapper;

        public StockRepository(DummyContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        /// <summary>
        /// Creates the specified object dto.
        /// </summary>
        /// <param name="objDTO">The object dto.</param>
        /// <returns></returns>
        public async Task<StockDTO> Create(StockDTO objDTO)
        {
            var obj = _mapper.Map<StockDTO, Stock>(objDTO);

            obj.CreatedDate = DateTime.Now;
            obj.UpdateDate = DateTime.Now;

            var addedObj = _db.Stocks.Add(obj);

            await _db.SaveChangesAsync();

            var newObjDTO = _mapper.Map<Stock, StockDTO>(addedObj.Entity);

            return newObjDTO;
        }

        /// <summary>
        /// Deletes the specified stock identifier.
        /// </summary>
        /// <param name="stockId">The stock identifier.</param>
        /// <returns></returns>
        public async Task<int> Delete(long stockId)
        {
            var obj = _db.Stocks.FirstOrDefault(x => x.StockId == stockId);

            if (obj == null)
                return 0;

            _db.Stocks.Remove(obj);

            return await _db.SaveChangesAsync();
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<StockDTO>> GetAll()
        {
            IEnumerable<StockDTO> entities = new List<StockDTO>();

            await Task.Run(() => 
            {
                entities = _mapper.Map<IEnumerable<Stock>, IEnumerable<StockDTO>>(_db.Stocks.Include(q => q.StockSector));
            });
            
            return entities;
        }

        /// <summary>
        /// Gets the by stock identifier.
        /// </summary>
        /// <param name="stockId">The stock identifier.</param>
        /// <returns></returns>
        public async Task<StockDTO> GetByStockId(long stockId)
        {
            var stockDTO = new StockDTO();
            var stock = new Stock();

            await Task.Run(() =>
            {
                stock = _db.Stocks.FirstOrDefault(x => x.StockId == stockId);
            });

            if (stock == null)
                return new StockDTO();

            stockDTO = _mapper.Map<Stock, StockDTO>(stock);

            return stockDTO;
        }

        /// <summary>
        /// Updates the specified object dto.
        /// </summary>
        /// <param name="objDTO">The object dto.</param>
        /// <returns></returns>
        public async Task<StockDTO> Update(StockDTO objDTO)
        {
            var objFromDb = _db.Stocks.FirstOrDefault(x => x.StockId == objDTO.StockId);

            if (objFromDb == null)
                return new StockDTO();

            objFromDb.Code = objDTO.Code;
            objFromDb.Name = objDTO.Name;
            objFromDb.StockSectorId = objDTO.StockSectorId;
            objFromDb.IsActive = objDTO.IsActive;
            objFromDb.UpdateDate = DateTime.Now;

            await _db.SaveChangesAsync();

            var update = _mapper.Map<Stock, StockDTO>(objFromDb);

            return update;

        }
    }
}
