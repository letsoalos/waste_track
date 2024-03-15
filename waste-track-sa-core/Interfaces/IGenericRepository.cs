using System.Linq.Expressions;
using waste_track_sa_core.Entities;
using waste_track_sa_core.Specifications;

namespace waste_track_sa_core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<int> CountAsync(ISpecification<T> spec);
        void Add(T entity);
        void UpdateAsync(T entity);
        void Remove(T entity);
        void RomoveRange(IEnumerable<T> entity);
    }
}