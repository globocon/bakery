using AutoMapper;
using BMS.Data.Helpers;
using BMS.Data.Models;
using BMS.Data.Services;
using Microsoft.AspNetCore.Http;

namespace BMS.Data.Providers
{
    public interface IUomDataProvider
    {
        Task<List<UomMaster>> GetUoms();        
    }

    public class UomDataProvider : IUomDataProvider
    {
        private readonly IDbService _dbService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UomDataProvider(IDbService dbService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public async Task<List<UomMaster>> GetUoms()
        {
            return await _dbService.GetUoms();
        }
                
    }
}



