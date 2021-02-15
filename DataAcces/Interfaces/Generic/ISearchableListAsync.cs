using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Interfaces.Generic
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISearchableListAsync<T>
    {
        Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> query = null);
    }
}
