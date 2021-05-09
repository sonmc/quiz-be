using System.Collections.Generic;

namespace quiz_be.Repositories
{
    public interface IGeneralRepository<T> where T : class
    {
        List<T> GetAll();
        T Add(T entity);
        T Update(T entity);
        T Get(int id);
        T Delete(int id);
    }
}
