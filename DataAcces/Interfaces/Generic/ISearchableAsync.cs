using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAcces.Interfaces.Generic
{
    public interface ISearchableAsync<T>
    {
        Task<T> GetSingleAsync(Expression<Func<T, bool>> query);
    }
}
