using FuzulCase.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FuzulCase.Application.Repositories
{
    public interface IGenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(int id);
        Task<bool> AddAsync(T model);
        Task<int> SaveAsync();
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(int id, T model);

    }
}
