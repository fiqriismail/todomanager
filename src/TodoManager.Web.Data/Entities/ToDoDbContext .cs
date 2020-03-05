using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TodoManager.Web.Data.Entities
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext()
        {

        }
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base (options)
        {

        }

        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<User> Users { get; set; }

        public void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { Id = 1, FirstName = "Hansamali", LastName = "Gamage" });
        }

    }
}
