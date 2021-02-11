using System.Threading.Tasks;

namespace DataAcces.Interfaces.Generic
{
    /// <summary>
    /// Enables editing existing entity in the database
    /// </summary>
    /// <typeparam name="T1">Entity's indenifier. Mostly <see cref="int"/>, <see cref="System.Guid"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public interface IEditableAsync<T1, in T2>
    {
        Task<T1> EditAsync(T2 data);
    }
}
