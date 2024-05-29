using FuzulCase.Application.Repositories;
using FuzulCase.Application.Result;
using FuzulCase.Domain.Entities;
using FuzulCase.Domain.Entities.Estate;
using FuzulCase.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuzulCase.APIs.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ILogger<CityController> _logger;
        private readonly IConfiguration _configuration;
        private readonly  ICityRepository _cityRepository;

        public CityController(ILogger<CityController> logger, ICityRepository cityRepository, IConfiguration configuration)
        {
            _logger = logger;
            _cityRepository = cityRepository;
            _configuration = configuration;
        }

        [HttpGet]
        public Response<IQueryable<City>> GetAllCities()
        {
            try
            {
                IQueryable<City> cities = _cityRepository.GetAll();
                _logger.LogInformation("Cities listed: {EstateCount}", cities.Count());
                return Response<IQueryable<City>>.Success(cities, 200);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while listing cities");
                return Response<IQueryable<City>>.Fail("An error occurred while listing cities", 500, false);
            }
        }

    }
}
