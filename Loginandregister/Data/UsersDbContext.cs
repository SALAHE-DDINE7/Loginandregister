using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loginandregister.Data
{
    public class UsersDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Modifie le Server si nécessaire
            optionsBuilder.UseSqlServer("Server=DESKTOP-SIMBA\\SQLEXPRESS;Database=ManageLogin;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }
        public DbSet<Model.Users> Users { get; set; }
    }
}
