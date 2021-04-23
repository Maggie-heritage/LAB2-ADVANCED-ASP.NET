using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoWebAPI.Model;

namespace ToDoAPI.Model
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
           : base(options)
        {
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
