using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using waste_track_sa_core.Entities;
using waste_track_sa_core.Interfaces;
using waste_track_sa_core.Specifications;

namespace waste_track_sa_infrastructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly DataContext _context;
        internal DbSet<T> dbSet;
        public GenericRepository(DataContext context)
        {
            _context = context;
            this.dbSet = _context.Set<T>();
        }


        public async Task<T> Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            IQueryable<T> query = dbSet;

            return await query.ToListAsync();
        }
        
        public async Task<T> GetEntityWithSpec(ISpecification<T> spec)
        {  
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }   

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }


        public void Add(T entity)
        {
            dbSet.Add(entity);
        } 

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RomoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }


        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(dbSet.AsQueryable(), spec);
        }

        public void UpdateAsync(T entity)
        {
            dbSet.Attach(entity);
            dbSet.Entry(entity).State = EntityState.Modified;
        }
    }
}