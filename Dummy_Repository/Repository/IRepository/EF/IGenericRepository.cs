using System.Linq.Expressions;

namespace Dummy_Repository.Repository.IRepository;

public interface IGenericRepository<T> where T : class
{
    /// <summary>
    /// Gets all.
    /// </summary>
    /// <returns></returns>
    Task <IEnumerable<T>> GetAll();

    /// <summary>
    /// Gets the by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    Task<T> GetByID(object id);

    /// <summary>
    /// Filters the by parameter.
    /// </summary>
    /// <param name="predicate">The predicate.</param>
    /// <returns></returns>
    Task <IEnumerable<T>> FilterByParam(Expression<Func<T, bool>> predicate);

    /// <summary>
    /// Inserts the specified object.
    /// </summary>
    /// <param name="obj">The object.</param>
    Task Insert(T obj);

    /// <summary>
    /// Updates the specified object.
    /// </summary>
    /// <param name="obj">The object.</param>
    Task Update(T obj);

    /// <summary>
    /// Deletes the specified identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    Task Delete(object id);

    /// <summary>
    /// Saves this instance.
    /// </summary>
    Task Save();
}
