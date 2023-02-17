using CookBook.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models.ViewModels
{
    public class CategoryVM
    {
        public CategoryVM(Category src)
        {
            Id = src.Id;
            Name = src.Name;
            Created = src.Created;
            Updated = src.Updated;
            Deleted = src.Deleted;

        }
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
    }
}
