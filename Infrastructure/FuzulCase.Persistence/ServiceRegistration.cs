using FluentValidation;
using FuzulCase.Application.Repositories;
using FuzulCase.Application.Validators.Estate;
using FuzulCase.Domain.Entities.Estate;
using FuzulCase.Persistence.Contexts;
using FuzulCase.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzulCase.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<FuzulCaseDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IEstateRepository, EstateRepository>();
            services.AddScoped<ICityRepository, CityRepository>();

        }
    }
}
