using CookBook.Models.Entities;
using CookBook.Repo.Repositories.Interfaces;
using CookBook.Repo.Repositories;
using CookBook.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Repo.Repositories
{
   public class IngredientRepo : BaseRepo<Ingredient, Guid, string, ApplicationDbContext>, IIngredientRepo
    {
        private readonly ApplicationDbContext _context;
        public IngredientRepo(ApplicationDbContext context)
            : base(context)
        {
        }
    }
   
}
 