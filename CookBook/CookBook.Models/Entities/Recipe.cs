using CookBook.Models.Entities.Interface;
using CookBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models.Entities
{
    public class Recipe :BaseEntity<Guid, string>, IDated
    {
        public Recipe() { }
        public Recipe(RecipeVM src) 
        {
            Category = src.Category;
        }

        public string Category { get; set; } = string.Empty;


        //Collections of steps etc 
        public ICollection<Direction>? Directions { get; set; }

        public ICollection<Ingredient>? Ingredients { get; set; }


        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }

    }
}
