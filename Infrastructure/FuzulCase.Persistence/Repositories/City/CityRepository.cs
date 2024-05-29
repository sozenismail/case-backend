using FuzulCase.Application.Repositories;
using FuzulCase.Domain.Entities;
using FuzulCase.Domain.Entities.Estate;
using FuzulCase.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzulCase.Persistence.Repositories
{
 
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        private readonly FuzulCaseDbContext _context;
        public CityRepository(FuzulCaseDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
