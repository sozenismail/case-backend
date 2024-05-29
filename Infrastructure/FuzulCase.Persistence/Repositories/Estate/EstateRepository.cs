using FuzulCase.Application.Repositories;
using FuzulCase.Domain.Entities.Estate;
using FuzulCase.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzulCase.Persistence.Repositories
{
    public class EstateRepository : GenericRepository<Estate>,IEstateRepository
    {
        private readonly FuzulCaseDbContext _context;
        public EstateRepository(FuzulCaseDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IQueryable<EstateResponseDto>> GetAllFilteredEstatesAsync(EstateFilterDto estateFilterDto)
        {
            IQueryable<Estate> estates = _context.Estates;

            // Fiyat filtresi
            if (estateFilterDto.MaxPrice.HasValue)
            {
                estates = estates.Where(x => x.Price <= estateFilterDto.MaxPrice.Value);
            }

            if (estateFilterDto.MinPrice.HasValue)
            {
                estates = estates.Where(x => x.Price >= estateFilterDto.MinPrice.Value);
            }

            // Metrekare filtresi
            if (estateFilterDto.MaxM2.HasValue)
            {
                estates = estates.Where(x => x.FieldM2 <= estateFilterDto.MaxM2.Value);
            }

            if (estateFilterDto.MinM2.HasValue)
            {
                estates = estates.Where(x => x.FieldM2 >= estateFilterDto.MinM2.Value);
            }

            // Şehir filtresi
            if (estateFilterDto.CityId.HasValue)
            {
                estates = estates.Where(x => x.CityId == estateFilterDto.CityId.Value);
            }

            IQueryable<EstateResponseDto> response = estates.Select(e => new EstateResponseDto
            {
                Id = e.Id,
                Title = e.Title,
                ListingDate = e.ListingDate,
                FieldM2 = e.FieldM2,
                Price = e.Price,
                CityId = e.CityId,
                Thumbnail = e.Thumbnail
            });

            return response;
        }
    }
}
