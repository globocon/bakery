using AutoMapper;
using BMS.Data.Entity;
using BMS.Data.Models;
using BMS.Data.Services;

namespace BMS.Data.Providers
{
    public interface IUomDataProvider
    {
        Task<List<UomMaster>> GetUoms();
        Task<List<UomAddEditModal>> GetUomsConverted();
        Task<UomAddEditModal?> GetUomById(int id);
        Task AddUom(UomAddEditModal uomedm);
        Task UpdateUom(UomAddEditModal uomedm);
        Task DeleteUom(int id);
    }

    public class UomDataProvider : IUomDataProvider
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;

        public UomDataProvider(IDbService dbService, IMapper mapper)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<UomMaster>> GetUoms()
        {
            return await _dbService.GetUoms();
        }
        public async Task<List<UomAddEditModal>> GetUomsConverted()
        {
            var r = await _dbService.GetUoms();
            var rl = _mapper.Map<List<UomAddEditModal>>(r);
            return rl;
        }

        public async Task<UomAddEditModal?> GetUomById(int id)
        {
            var r = await _dbService.GetUomById(id);
            var rl = _mapper.Map<UomAddEditModal>(r);
            return rl;
        }

        public async Task AddUom(UomAddEditModal uomedm)
        {
            if (uomedm == null)
                throw new ArgumentNullException(nameof(uomedm));

            var newUomedm = _mapper.Map<UomMaster>(uomedm);
            await _dbService.AddUom(newUomedm);
        }

        public async Task UpdateUom(UomAddEditModal uomedm)
        {
            if (uomedm == null)
            {
                throw new ArgumentNullException(nameof(uomedm));
            }
            var existing = await _dbService.GetUomById(uomedm.Id);
            if (existing == null)
            {
                throw new ArgumentException($"UOM with ID {uomedm.Id} not found.");
            }
            var similar = await _dbService.GetUomByName(uomedm.UOMName);
            if (similar != null && similar.Id != uomedm.Id)
            {
                throw new ArgumentException($"Uom with name {uomedm.UOMName} already exists.");
            }
            _mapper.Map(uomedm, existing);

            await _dbService.UpdateUom(existing);
            return;
        }

        public async Task DeleteUom(int id)
        {
            await _dbService.DeleteUom(id);
        }

    }
}



