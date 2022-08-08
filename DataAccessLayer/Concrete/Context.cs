using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public  class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SPACE\\SQLEXPRESS;database=DbNewOopCore1;integrated security=true;");//context configursayon
        }
        public DbSet<Product> Products { get; set; } //products Sql de ki isimdir.
        public DbSet<Customer> Customers { get; set; } //products Sql de ki isimdir.
        public DbSet<Category> Categories { get; set; } //products Sql de ki isimdir.
        public DbSet<Job> Jobs { get; set; } //products Sql de ki isimdir.
    }
}
