using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using InternshipProject.Data.Model;


namespace InternshipProject.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
