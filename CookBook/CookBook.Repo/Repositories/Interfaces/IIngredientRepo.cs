using CookBook.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Repo.Repositories.Interfaces
{
    public interface IIngredientRepo : IBaseRepo<Ingredient, Guid>
    {
    }
}
