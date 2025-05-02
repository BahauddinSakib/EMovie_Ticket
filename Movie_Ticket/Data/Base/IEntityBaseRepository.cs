using Movie_Ticket.Models;

namespace Movie_Ticket.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class,IEntityBase, new()
    {
        //Generic solution
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);  // Updated return type
        Task DeleteAsync(int id);  // Changed to async
    }
}
