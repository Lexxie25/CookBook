using CookBook.Models.Entities.Interface;
using CookBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models.Entities
{
    public  class User :BaseEntity<string, string>
    {
        public User() { }

        public User(UserVM src)
        {
            LastName = src.LastName;
        }

        public string LastName { get; set; } = string.Empty;
    }
}
