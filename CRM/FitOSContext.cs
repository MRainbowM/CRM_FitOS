using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using MySql.Data.EntityFrameworkCore.Extensions;



namespace CRM
{
    public partial class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<ServiceInTariff> ServicesInTariffs { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<TrainerService> TrainerServices { get; set; }
        public DbSet<BalanceCard> BalanceCards { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ServiceInRoom> ServiceInRooms { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<ScheduleService> ScheduleServices { get; set; }
        public DbSet<TrainerInSchedule> TrainersInSchedule { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceInTariff>().HasKey(u => new { u.ID_Service, u.ID_Tariff });
            modelBuilder.Entity<TrainerService>().HasKey(u => new { u.ID_Service, u.ID_Trainer });
            modelBuilder.Entity<BalanceCard>().HasKey(u => new { u.ID_Service, u.ID_Card });
            modelBuilder.Entity<ServiceInRoom>().HasKey(u => new { u.ID_Service, u.ID_Room });
            modelBuilder.Entity<TrainerInSchedule>().HasKey(u => new { u.ID_Trainer, u.ID_Schedule });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;;UserId=root;Password='';Database=FitOS;");
        }




    }


    
}
