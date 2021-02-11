using System.Threading.Tasks;

namespace DataAcces.Interfaces.Generic
{
    /// <summary>
    /// Enables deleting existing entity in the database to selected date
    /// </summary>
    /// <typeparam name="T1">Entity's indenifier. Mostly <see cref="int"/>, <see cref="System.Guid"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public interface IRemovableAsync<T1, in T2>
    {
        Task<T1> DeleteAsync(T2 data);
    }
}
