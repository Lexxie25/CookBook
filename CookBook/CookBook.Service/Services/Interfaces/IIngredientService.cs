using CookBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Service.Services.Interfaces
{
    public interface IIngredientService
    {
        Task<IngredientVM> Create(IngredientVM src);

        Task<IngredientVM> GetById(Guid Id);

        Task<List<IngredientVM>> GetAll();

        Task<IngredientVM> Update(IngredientVM src);

        Task Delete(Guid Id);
    }
}
