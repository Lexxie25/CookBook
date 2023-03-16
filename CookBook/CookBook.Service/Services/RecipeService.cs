using CookBook.Models.Entities;
using CookBook.Models.ViewModels;
using CookBook.Repo;
using CookBook.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CookBook.Service.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IUnitOfWork _uow;
        public RecipeService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<RecipeVM> Create(RecipeVM src)
        {
            var newEntity = new Recipe(src);

            _uow.Recipes.Create(newEntity);
            await _uow.SaveAsync();

            var model = new RecipeVM(newEntity);

            return model;
        }

        //get all 
        public async Task<List<RecipeVM>> GetAll()
        {
            var results = await _uow.Recipes.GetAll();

            var models = results.Select(recipe => new RecipeVM(recipe)).ToList();

            return models;
        }

        //get by Id 
        public async Task<RecipeVM> GetById(Guid Id)
        {
            var result = await _uow.Recipes.GetById(Id);

            var model = new RecipeVM(result);

            return model;
        }

        //update
        public async Task<RecipeVM> Update(RecipeVM src)
        {
            var entity = await _uow.Recipes.GetById(src.Id);

           
            entity.Name = src.Name;
            entity.Category = src.Category;

            _uow.Recipes.Update(entity);
            await _uow.SaveAsync();

            var model = new RecipeVM(entity);

            return model;
        }

        //Delete
        public async Task Delete(Guid Id)
        {
            var entity = await _uow.Recipes.GetById(Id);

            _uow.Recipes.Delete(entity);

            await _uow.SaveAsync();
        }

    }
}
