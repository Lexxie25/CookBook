using CookBook.Models.Entities.Interface;
using CookBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models.Entities
{
    public class Category : BaseEntity<Guid, string>, IDated
    {
        public Category() { }
        public Category(CategoryVM src) { }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
    }
}
