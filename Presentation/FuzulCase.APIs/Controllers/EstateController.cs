using FuzulCase.Application.Repositories;
using FuzulCase.Application.Result;
using FuzulCase.Domain.Entities.Estate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;
using Serilog;
using FluentValidation;

namespace FuzulCase.APIs.Controllers
{
    [Route("[controller]/[action]")]
    
    [ApiController]
    public class EstateController : ControllerBase
    {
        private readonly ILogger<EstateController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IEstateRepository _estateRepository;

        public EstateController(ILogger<EstateController> logger, 
            IEstateRepository estateRepository, 
            IConfiguration configuration)
        {
            _logger = logger;
            _estateRepository = estateRepository;
            _configuration = configuration;
        }


        [HttpGet]
        public async Task<Response<IQueryable<EstateResponseDto>>> GetAllFilteredEstates([FromQuery] EstateFilterDto estateFilter)
        {
            try
            {
                IQueryable<EstateResponseDto> estates = await _estateRepository.GetAllFilteredEstatesAsync(estateFilter);
                _logger.LogInformation("Estates listed: {EstateCount}", estates.Count());
                return Response<IQueryable<EstateResponseDto>>.Success(estates, 200);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while listing estates with filter: {@EstateFilter}", estateFilter);
                return Response<IQueryable<EstateResponseDto>>.Fail("An error occurred while listing estates", 500, false);
            }
        }


    }
}
