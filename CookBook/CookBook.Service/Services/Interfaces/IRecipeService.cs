using CookBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Service.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<RecipeVM> Create(RecipeVM src);

        Task<RecipeVM> GetById(Guid Id);

        Task<List<RecipeVM>> GetAll();

        Task<RecipeVM> Update(RecipeVM src);

        Task Delete(Guid Id);
    }
}
