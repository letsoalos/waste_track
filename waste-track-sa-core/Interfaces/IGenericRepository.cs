using System.Linq.Expressions;
using waste_track_sa_core.Entities;
using waste_track_sa_core.Specifications;

namespace waste_track_sa_core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(Expression<Func<T, bool>> filter, ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);

        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        //void Update(T entity);
        void Remove(T entity);
        void RomoveRange(IEnumerable<T> entity);
    }
}