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
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;
        public UserService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        //create 
        public async Task<UserVM> Create(UserVM src)
        {
            var newEntity = new User(src);

            _uow.Users.Create(newEntity);
            await _uow.SaveAsync();

            var model = new UserVM(newEntity);

            return model;
        }
        // update 
        public async Task<UserVM> Update(UserVM src)
        {
            var entity = await _uow.Users.GetById(src.Id);

            entity.Name = src.Name;
            entity.LastName = src.LastName;

            _uow.Users.Update(entity);
            await _uow.SaveAsync();

            var model = new UserVM(entity);

            return model;
        }
        //get by Id 
        public async Task<UserVM> GetById(string Id)
        {
            var result = await _uow.Users.GetById(Id);

            var model = new UserVM(result);

            return model;
        }
    }
}
