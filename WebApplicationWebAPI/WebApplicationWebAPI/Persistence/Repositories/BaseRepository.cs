using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWebAPI.Persistence.Contexts;

namespace WebApplicationWebAPI.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
