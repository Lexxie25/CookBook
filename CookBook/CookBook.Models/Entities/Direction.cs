using CookBook.Models.Entities.Interface;
using CookBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models.Entities
{
    public class Direction :BaseEntity<Guid, string>, IDated
    {
        public Direction() { }
        public Direction(DirectionVM src) 
        {
            Steps = src.Steps;
            Instructions = src.Instructions;
            Notes = src.Notes;
        }
        public int Steps { get; set; }

        public string Instructions { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }

    }
}
