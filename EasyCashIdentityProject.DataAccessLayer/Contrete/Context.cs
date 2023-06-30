using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace EasyCashIdentityProject.DataAccessLayer.Contrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=104.247.162.242\\MSSQLSERVER2019;Database=akadem58_easycash;User Id=akadem58_easycash;Password=014Gkej~3;TrustServerCertificate=True;MultipleActiveResultSets=true;");
        }
        public DbSet<CustomerAccountProcess> CustomerAccountProcesss
        {
            get; set;
        }
        public DbSet<CustemerAccount> CustomerAccounts
        {
            get; set;
        }

    }
}
