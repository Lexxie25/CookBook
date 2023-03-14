using CookBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Service.Services.Interfaces
{
    public interface IDirectionService
    {
        Task<DirectionVM> Create(DirectionVM src);

        Task<DirectionVM> GetById(Guid Id);

        Task<List<DirectionVM>> GetAll();


        Task<DirectionVM> Update(DirectionVM src);

        Task Delete(Guid Id);

    }
}
