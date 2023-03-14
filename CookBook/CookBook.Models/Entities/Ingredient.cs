using CookBook.Models.Entities.Interface;
using CookBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models.Entities
{
    public class Ingredient :BaseEntity<Guid, string>, IDated
    {
        public Ingredient() { }
        public Ingredient(IngredientVM src) 
        {
            Item = src.Item;
            Qty = src.Qty;
            Size = src.Size;
            Serving = src.Serving;
        }

        public string Item { get; set; } = string.Empty;

        public int Qty { get; set; }

        public string Size { get; set; } = string.Empty;

        public string Serving { get; set; } = string.Empty;


        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }

    }
}
