using CookBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Service.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserVM> Create(UserVM src);

        Task<UserVM> GetById(string Id);

        Task<UserVM> Update(UserVM src);

    }
}
