using FuzulCase.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FuzulCase.Persistence.Contexts;
using FuzulCase.Application.Repositories;

namespace FuzulCase.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        private readonly FuzulCaseDbContext _context;

        public GenericRepository(FuzulCaseDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
           => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
           => Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
           => await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(int id)
           => await Table.FindAsync(id);

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            await SaveAsync();
            return entityEntry.State == EntityState.Added;
        }

        public async Task<int> SaveAsync()
         => await _context.SaveChangesAsync();

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var entityToDelete = await _context.Set<T>().FindAsync(id);

            if (entityToDelete == null)
            {
                return false;
            }

            _context.Set<T>().Remove(entityToDelete);
            await SaveAsync();
            return true;
        }


        public async Task<bool> UpdateAsync(int id, T model)
        {
            var existingEntity = await GetByIdAsync(id);

            if (existingEntity == null)
            {
                return false;
            }

            _context.Entry(existingEntity).CurrentValues.SetValues(model);

            await SaveAsync();

            return true;
        }
    }
}
