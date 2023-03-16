using CookBook.Models.Entities;
using CookBook.Models.ViewModels;
using CookBook.Repo;
using CookBook.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Service.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IUnitOfWork _uow;
       
        public IngredientService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IngredientVM> Create(IngredientVM src)
        {
            var newEntity = new Ingredient(src);
            _uow.Ingredients.Create(newEntity);
            await _uow.SaveAsync();

            var model = new IngredientVM(newEntity);

            return model; 
        }

        public async Task<List<IngredientVM>> GetAll()
        {
            var results = await _uow.Ingredients.GetAll();

            var models = results.Select(ingredient => new IngredientVM(ingredient)).ToList();

            return models;
        }

        public async Task<IngredientVM> GetById(Guid Id)
        {
            var result = await _uow.Ingredients.GetById(Id);

            var model = new IngredientVM(result);

            return model;
        }

        public async Task<IngredientVM> Update(IngredientVM src)
        {
            var entity = await _uow.Ingredients.GetById(src.Id);

            entity.Name = src.Name;
            entity.Item = src.Item;
            entity.Qty = src.Qty;
            entity.Size = src.Size;
            entity.Serving = src.Serving;

            _uow.Ingredients.Update(entity);
            await _uow.SaveAsync();

            var model = new IngredientVM(entity);

            return model;
        }

        public async Task Delete(Guid Id)
        {
            var entity = await _uow.Ingredients.GetById(Id);
           
            _uow.Ingredients.Delete(entity);
            
            await _uow.SaveAsync();
        }
    }
}
