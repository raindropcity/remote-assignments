using Assignment_1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1.Data
{
    /* we have to injects this AssignmentDbContext class inside the program.cs file, otherwise our App would have no idea about this AssignmentDbContext class(dbcontext) and what properties we want to create */
    public class AssignmentDbContext : DbContext
    {
        //Contructor
        public AssignmentDbContext(DbContextOptions options) : base(options)
        {

        }

        //properties
        // properties are use to access the table that Entity Framework Core will create in our database
        // This will be the table name that gets created ultimately from the Entity Framework Core migrations
        public DbSet<User> Users { get; set; }
    }
}
