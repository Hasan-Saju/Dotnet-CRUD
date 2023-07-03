using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        //ctor for creating constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
             
        }

        //creating table in DB
        public  DbSet<Category> Category { get; set; }
		public DbSet<ApplicationType> ApplicationType { get; set; }
	}
}
//Tools-NuggetManagerConsole-Migration
//migration script: add-migration AddApplicationToDatabase; update-database