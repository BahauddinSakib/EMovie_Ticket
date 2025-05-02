using Microsoft.EntityFrameworkCore;
using Movie_Ticket.Data.Base;
using Movie_Ticket.Models;

namespace Movie_Ticket.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorsService
    {
        //private readonly AppDbContext _context;

        public ActorService(AppDbContext context) : base(context)
        {

        }
       
    }
}

