using System.Collections.Generic;
using System.Threading.Tasks;
namespace UdemyMVC.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T>? GetAll();
        T? GetById(object id);
         void Add(T entity);
         void Update(T entity);
         void Delete(object id);
    }
}
