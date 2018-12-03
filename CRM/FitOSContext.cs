using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using MySql.Data.EntityFrameworkCore.Extensions;



namespace CRM
{
    public partial class ApplicationContext : DbContext
    {

        //public DbSet<Us> Usdd { get; set; }
        //public DbSet<Client> User { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        //public DbSet<Trainer> User { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;;UserId=root;Password='';Database=FitOS;");
        }
    }
}
