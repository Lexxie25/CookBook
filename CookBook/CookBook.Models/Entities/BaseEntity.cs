using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models.Entities
{
    public class BaseEntity<TId, TName >
    {
        [Key]   
        public TId Id { get; set; }

        public TName Name { get; set; }


    }
}
