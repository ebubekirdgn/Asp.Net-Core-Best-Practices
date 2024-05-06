using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        //productRepository.GetAll(x=>x.id>5).OrderBy.ToListAsync();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

        //productRepository.where(x=>x.id>5).OrderBy.ToListAsync();
        // IQueryable olarak aldık cunku OrderBy ile birlikte alsın dedik.
        //<T,bool> T x'e bool ise x.id>5 buna karsılık gelmektedir.
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity); // update ve delete'in async'i yoktur.
        void Remove(T entity); // update ve delete'in async'i yoktur.
        void RemoveRange(IEnumerable<T> entities); // update ve delete'in async'i yoktur.


    }
}
