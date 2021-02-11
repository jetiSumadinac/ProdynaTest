using System.Linq;

namespace DataAcces.Infrastructure
{
    public abstract class BaseRepository<T>
    {
        protected abstract IQueryable<T> GetEntities();
    }
}
