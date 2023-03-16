using CookBook.Models.Entities;
using CookBook.Models.ViewModels;
using CookBook.Repo;
using CookBook.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Service.Services
{
    public class DirectionService : IDirectionService
    {
        private readonly IUnitOfWork _uow;
        public DirectionService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<DirectionVM> Create(DirectionVM src)
        {
            var newEntity = new Direction(src);

            _uow.Directions.Create(newEntity);
            await _uow.SaveAsync();

            var model = new DirectionVM(newEntity);

            return model; 
        }

        //get all 
        public async Task<List<DirectionVM>> GetAll()
        {
            var results = await _uow.Directions.GetAll();

            var models = results.Select(direction => new DirectionVM(direction)).ToList();

            return models;
        }

        //get by Id 
        public async Task<DirectionVM> GetById(Guid Id)
        {
            var result = await _uow.Directions.GetById(Id);

            var model = new DirectionVM(result);

            return model;
        }
    
        //update
        public async Task<DirectionVM> Update(DirectionVM src)
        {
            var entity = await _uow.Directions.GetById(src.Id);

            entity.Name = src.Name;
            entity.Steps = src.Steps;
            entity.Instructions = src.Instructions;
            entity.Notes = src.Notes;

            _uow.Directions.Update(entity);
            await _uow.SaveAsync();

            var model = new DirectionVM(entity);

            return model; 
        }

        //Delete
        public async Task Delete(Guid Id)
        {
            var entity = await _uow.Directions.GetById(Id);

            _uow.Directions.Delete(entity);

            await _uow.SaveAsync();
        }

    }
}
