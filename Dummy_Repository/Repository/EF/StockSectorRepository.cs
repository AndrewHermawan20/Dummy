using AutoMapper;
using Dummy_Data;
using Dummy_Model;
using Dummy_Data.Model;
using Dummy_Repository.Repository.IRepository;

namespace Dummy.Repository
{
    public class StockSectorRepository : IStockSectorRepository
    {
        private readonly DummyContext _db;
        private readonly IMapper _mapper;

        public StockSectorRepository(DummyContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        /// <summary>
        /// Creates the specified object dto.
        /// </summary>
        /// <param name="objDTO">The object dto.</param>
        /// <returns></returns>
        public async Task<StockSectorDTO> Create(StockSectorDTO objDTO)
        {
            var obj = _mapper.Map<StockSectorDTO, StockSector>(objDTO);

            obj.CreateDate = DateTime.Now;
            obj.UpdateDate = DateTime.Now;

            var addedObj = _db.StockSectors.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<StockSector, StockSectorDTO>(addedObj.Entity);
        }

        /// <summary>
        /// Deletes the specified StockSector identifier.
        /// </summary>
        /// <param name="StockSectorId">The StockSector identifier.</param>
        /// <returns></returns>
        public async Task<int> Delete(int StockSectorId)
        {
            var obj = _db.StockSectors.FirstOrDefault(x => x.StockSectorId == StockSectorId);

            if (obj == null)
                return 0;

            _db.StockSectors.Remove(obj);
            return await _db.SaveChangesAsync();
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<StockSectorDTO>> GetAll()
        {
            IEnumerable<StockSectorDTO> entities = new List<StockSectorDTO>();
            await Task.Run(() =>
            {
                entities = _mapper.Map<IEnumerable<StockSector>, IEnumerable<StockSectorDTO>>(_db.StockSectors);
            });
            return entities;
        }

        /// <summary>
        /// Gets the by StockSector identifier.
        /// </summary>
        /// <param name="StockSectorId">The StockSector identifier.</param>
        /// <returns></returns>
        public async Task<StockSectorDTO> GetByStockSectorId(int StockSectorId)
        {
            StockSector? obj = new StockSector();
            await Task.Run(() =>
            {
                obj = _db.StockSectors.FirstOrDefault(x => x.StockSectorId == StockSectorId);
            });

            if (obj == null)
                return new StockSectorDTO();

            var StockSector = _mapper.Map<StockSector, StockSectorDTO>(obj);

            return StockSector;
        }

        /// <summary>
        /// Updates the specified object dto.
        /// </summary>
        /// <param name="objDTO">The object dto.</param>
        /// <returns></returns>
        public async Task<StockSectorDTO> Update(StockSectorDTO objDTO)
        {
            var objFromDb = _db.StockSectors.FirstOrDefault(x => x.StockSectorId == objDTO.StockSectorId);

            if (objFromDb == null)
                return new StockSectorDTO();

            objFromDb.Code = objDTO.Code;
            objFromDb.Name = objDTO.Name;
            objFromDb.UpdateDate = DateTime.Now;

            await _db.SaveChangesAsync();

            var update = _mapper.Map<StockSector, StockSectorDTO>(objFromDb);

            return update;
        }
    }
}