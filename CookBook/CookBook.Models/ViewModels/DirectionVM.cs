using CookBook.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CookBook.Models.ViewModels
{
    public class DirectionVM
    {
        public DirectionVM(Direction src)
        {
            Id = src.Id;
            Name = src.Name;
            Steps = src.Steps;
            Instructions = src.Instructions;
            Notes = src.Notes;

        }
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Steps { get; set; }

        public string Instructions { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;


        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
    }
 
}
