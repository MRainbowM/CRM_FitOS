using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using MySql.Data.EntityFrameworkCore.Extensions;



namespace CRM
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Us> Usdd { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;;UserId=root;Password='';Database=FitOS;");
        }
    }

}
