using CookBook.Models.Entities;
using CookBook.Models.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CookBook.Models.ViewModels
{
    public class IngredientsVM
    {
        public IngredientsVM(Ingredients src)
        {
            Id = src.Id;
            Name = src.Name;
            Item = src.Item;
            Qty = src.Qty;
            Size = src.Size;
            Serving = src.Serving;
            Created = src.Created;
            Updated = src.Updated;
            Deleted = src.Deleted;

        }
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Item { get; set; } = string.Empty;

        public int Qty { get; set; }

        public string Size { get; set; } = string.Empty;

        public string Serving { get; set; } = string.Empty;

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
    }
}
