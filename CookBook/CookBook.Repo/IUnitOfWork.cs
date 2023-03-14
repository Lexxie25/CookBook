using CookBook.Repo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Repo
{
    public interface IUnitOfWork
    {
        IDirectionRepo Directions { get;  }

        IIngredientRepo Ingredients { get; }

        IRecipeRepo Recipes { get; }

        IUserRepo Users { get; }

        Task SaveAsync();

    }
}
