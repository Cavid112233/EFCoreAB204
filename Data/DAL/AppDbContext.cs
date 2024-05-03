using EFCoreAB204.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAB204.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=CA-R214-PC03\\SQLEXPRESS;Database=ProductDBAB204;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }
}
