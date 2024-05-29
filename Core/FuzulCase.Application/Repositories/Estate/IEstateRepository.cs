using FuzulCase.Domain.Entities.Estate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzulCase.Application.Repositories
{
    public interface IEstateRepository : IGenericRepository<Estate>
    {
        Task<IQueryable<EstateResponseDto>> GetAllFilteredEstatesAsync(EstateFilterDto estateFilterDto);
    }
}
