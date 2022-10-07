using Microsoft.EntityFrameworkCore;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.DataBase
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Palavra> Palavras { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
            
    }
}
