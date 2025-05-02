using Movie_Ticket.Data.Base;
using Movie_Ticket.Models;

namespace Movie_Ticket.Data.Services
{
    public interface IActorsService : IEntityBaseRepository<Actor>
    {
        //Task<IEnumerable<Actor>> GetAllAsync();
        //Task<Actor> GetByIdAsync(int id);
        //Task AddAsync(Actor actor);
        //Task<Actor> UpdateAsync(int id, Actor newActor);  // Updated return type
        //Task DeleteAsync(int id);  // Changed to async
    }
}

