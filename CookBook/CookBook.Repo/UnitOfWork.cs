using CookBook.Repo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Repo.Repositories
{
    public class UnitOfWork: IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
       
        private IDirectionRepo _directionRepo;

        public IDirectionRepo Directions
        {
            get
            {
                if (_directionRepo == null)
                    _directionRepo = new DirectionRepo(_context);

                return _directionRepo;
            }
        }


        private IIngredientRepo _ingredientRepo;

        public IIngredientRepo Ingredients
        {
            get
            {
                if (_ingredientRepo == null)
                    _ingredientRepo = new IngredientRepo(_context);

                return _ingredientRepo;
            }
        }


        private IRecipeRepo _recipeRepo;

        public IRecipeRepo Recipes
        {
            get
            {
                if (_recipeRepo == null)
                    _recipeRepo = new RecipeRepo(_context);

                return _recipeRepo;
            }
        }

        private IUserRepo _userRepo;

        public IUserRepo Users
        {
            get
            {
                if (_userRepo == null)
                    _userRepo = new UserRepo(_context);

                return _userRepo;
            }
        }





#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public UnitOfWork(ApplicationDbContext context)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            _context = context;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
