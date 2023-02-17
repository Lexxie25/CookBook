using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models.ViewModels
{
    public class UserVM
    {
        public UserVM(Entities.User src)
        {
            Id = src.Id;
            Name = src.Name;
            LastName = src.LastName;
            Created = src.Created;
            Updated = src.Updated;
            Deleted = src.Deleted;

        }


        public Guid Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }


    }
}
 