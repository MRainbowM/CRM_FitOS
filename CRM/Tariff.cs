using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{

    //[Table("Tariffs")]
    public class Tariff
    {
        private int ID;
        private string Name;
        private int Duration;
        private double TotalCost;
        private DateTime StartDate;
        private DateTime ExpirationDate;
        private DateTime DateRemoved;
        private string DateDelete;
        private string Comment;
        //private Dictionary<DateTime, bool> Time;
        //private Dictionary<int, int> AmountService; //количество услуги в тарифе
        //private Dictionary<int, int> PeriodicityService; // периодичность услуги в тарифе

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int duration
        {
            get { return Duration; }
            set { Duration = value; }
        }
        public double totalCost
        {
            get { return TotalCost; }
            set { TotalCost = value; }
        }
        public DateTime startDate
        {
            get { return StartDate; }
            set { StartDate = value; }
        }
        public DateTime expirationDate
        {
            get { return ExpirationDate; }
            set { ExpirationDate = value; }
        }
        public DateTime dateRemoved
        {
            get { return DateRemoved; }
            set { DateRemoved = value; }
        }
        public string dateDelete
        {
            get { return DateDelete; }
            set { DateDelete = value; }
        }
        public string comment
        {
            get { return Comment; }
            set { Comment = value; }
        }

        //public ICollection<ServicesInTariff> ServicesInTariff { get; set; }

        public Tariff()
        {
            //ServicesInTariff = new List<ServicesInTariff>();
        }

        //public List<Service> Services;


        public int Add(string Name, int Duration, double TotalCost, DateTime StartDate, DateTime ExpirationDate, DateTime DateRemoved, string Comment)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Tariff tariff = new Tariff()
                {
                    name = Name,
                    duration = Duration,
                    totalCost = TotalCost,
                    startDate = StartDate,
                    expirationDate = ExpirationDate,
                    dateRemoved = DateRemoved,
                    comment = Comment
                };
                db.Tariffs.Add(tariff);
                db.SaveChanges();
                int ID_Tariff = tariff.id;
                return ID_Tariff;
            }
        }
        public void Save(int ID_Tariff, string Name, int Duration, double TotalCost, DateTime StartDate, DateTime ExpirationDate, DateTime DateRemoved, string Comment)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Tariff tariff = db.Tariffs.Where(c => c.id == ID_Tariff).FirstOrDefault();
                tariff.name = Name;
                tariff.duration = Duration;
                tariff.totalCost = TotalCost;
                tariff.startDate = StartDate;
                tariff.expirationDate = ExpirationDate;
                tariff.dateRemoved = DateRemoved;
                tariff.comment = Comment;

                db.SaveChanges();
            }
        }

        public static Tariff FindByID(int ID_Tariff)
        {
            ApplicationContext db = new ApplicationContext();
            Tariff tariff = db.Tariffs.Where(x => x.dateDelete == null && x.id == ID_Tariff).FirstOrDefault();
            return tariff;
        }

        public static List<Tariff> GetAll()
        {
            ApplicationContext db = new ApplicationContext();

            List<Tariff> TariffList = db.Tariffs
                    .Where(x => x.dateDelete == null)
                    .Select(x => new Tariff
                    {
                        id = x.id,
                        name = x.Name,
                        duration = x.Duration,
                        totalCost = x.TotalCost,
                        startDate = x.StartDate,
                        expirationDate = x.ExpirationDate,
                        dateRemoved = x.DateRemoved,
                        comment = x.Comment
                    }
                    ).ToList();
            return TariffList;
        }

        public static void Del(int ID)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Tariff tariff = db.Tariffs.Where(c => c.id == ID).FirstOrDefault();
                tariff.DateDelete = DateTime.Today.ToString();

                db.SaveChanges();
            }
        }

        public static void AddServiceInTariff(int ID_Service, int ID_Tariff, int Amount, int Periodicity) //добавить услуги в тариф
        {
            ServiceInTariff.Add(ID_Tariff, ID_Service, Amount, Periodicity);
        }
    }

}
