using CookBook.Models.Entities;
using CookBook.Repo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Repo.Repositories
{
    public class UserRepo : BaseRepo<User, string, string, ApplicationDbContext>,IUserRepo
    {
        private readonly ApplicationDbContext _context;
        public UserRepo(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
