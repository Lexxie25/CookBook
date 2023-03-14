using CookBook.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Repo
{
public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
            //This is where you can use the fluent API to have finer control over the database setup. 
            //Anything you can do with data annotations on the entity models can also be done with the fluent API. 
        }
        public DbSet<Recipe> Recipes => Set<Recipe>();
        public DbSet<User> Users => Set<User>();

    }
}



