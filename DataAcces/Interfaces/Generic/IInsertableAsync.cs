using System.Threading.Tasks;

namespace DataAcces.Interfaces.Generic
{
    /// <summary>
    /// Enables inserting new entity to the database repository.
    /// </summary>
    /// <typeparam name="T1">Entity's indenifier. Mostly <see cref="int"/>, <see cref="System.Guid"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public interface IInsertableAsync<T1, in T2>
    {
        Task<T1> InsertAsync(T2 data);
    }
}
