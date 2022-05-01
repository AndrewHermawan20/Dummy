using AutoMapper;
using Dummy_Data.Model;
using Dummy_Repository.Repository.IRepository;
using System.Linq.Expressions;

namespace Dummy.Repository;

public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public Task Delete(object id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> FilterByParam(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByID(object id)
    {
        throw new NotImplementedException();
    }

    public Task Insert(T obj)
    {
        throw new NotImplementedException();
    }

    public Task Save()
    {
        throw new NotImplementedException();
    }

    public Task Update(T obj)
    {
        throw new NotImplementedException();
    }
}
