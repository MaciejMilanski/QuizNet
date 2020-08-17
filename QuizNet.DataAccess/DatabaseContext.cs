using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizNet.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace QuizNet.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        
        }
    }
}
