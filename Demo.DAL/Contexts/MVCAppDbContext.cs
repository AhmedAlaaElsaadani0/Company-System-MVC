using Demo.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Contexts
{
    public class MVCAppDbContext : IdentityDbContext<ApplicationUser>
    {
        public MVCAppDbContext(DbContextOptions dbContext): base(dbContext){}

        ///protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        ///    =>  optionsBuilder.UseSqlServer("Server = .; Database = MVCAppG02Db; Trusted_Connection = True; MultipleActiveResultSets = true");

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        //public DbSet<IdentityUser> Users { get; set; }

        //public DbSet<IdentityRole> Roles { get; set; }
    }
}
