using CookBook.Models.Entities;
using CookBook.Repo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Repo.Repositories
{
    public class DirectionRepo : BaseRepo<Direction,Guid, string,  ApplicationDbContext>, IDirectionRepo
    {
        private readonly ApplicationDbContext _context;
        public DirectionRepo(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
