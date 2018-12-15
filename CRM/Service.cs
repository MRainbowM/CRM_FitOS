using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    [Table("Services")]
    public class Service
    {
        private int ID;
        private string Name;
        private int Duration;
        private decimal Cost;
        private int NumberOfPeople;
        private string Comment;
        private string DateDelete;

        public int id
        {
            get{return ID;}
            private set{ID = value;}
        }
        public string name
        {
            get { return Name; }
            private set { Name = value; }
        }
        public int duration
        {
            get { return Duration; }
            private set { Duration = value; }
        }
        public decimal cost
        {
            get { return Cost; }
            private set { Cost = value; }
        }
        public int numberOfPeople
        {
            get { return NumberOfPeople; }
            private set { NumberOfPeople = value; }
        }
        public string comment
        {
            get { return Comment; }
            private set { Comment = value; }
        }

        //public ICollection<ServicesInTariff> ServicesInTariff { get; set; }

        //public Service()
        //{
        //    ServicesInTariff = new List<ServicesInTariff>();
        //}

        //public List<Tariff> Tariffs;


        public int Add(string Name, decimal Cost, int NumberOfPeople, string Comment, int Duration)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Service service = new Service
                {
                    Name = Name,
                    Cost = Cost,
                    NumberOfPeople = NumberOfPeople,
                    Comment = Comment,
                    Duration = Duration
                };
                db.Services.Add(service);
                db.SaveChanges();
                int ID_Service = service.id;
                return ID_Service;
            }
        }

        public void Save(int ID_Service, string Name, decimal Cost, int NumberOfPeople, string Comment, int Duration)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Service service = db.Services.Where(c => c.id == ID_Service).FirstOrDefault();
                service.name = Name;
                service.cost = Cost;
                service.numberOfPeople = NumberOfPeople;
                service.comment = Comment;
                service.duration = Duration;

                db.SaveChanges();
            }
        }

        public static Service FindByID(int ID_Service)
        {
            ApplicationContext db = new ApplicationContext();
            Service service = db.Services.Where(x => x.DateDelete == null && x.ID == ID_Service).FirstOrDefault();
            return service;
        }

        public static int FindIDByName(string Name)
        {
            int ID = 0;
            List<Service> Services = Service.GetAll();
            for (int i = 0; i < Services.Count; i++)
            {
                if (Services[i].name == Name)
                {
                    ID = Services[i].id;
                }
            }
            return ID;
        }

        public static List<Service> GetAll()
        {
            ApplicationContext db = new ApplicationContext();

            List<Service> ServiceList = db.Services
                    .Where(x => x.DateDelete == null)
                    .Select(x => new Service
                    {
                        ID = x.ID,
                        Name = x.Name,
                        Comment = x.comment,
                        Cost = x.Cost,
                        NumberOfPeople = x.NumberOfPeople,
                        Duration = x.Duration
                    }).ToList();
            return ServiceList;
        }

        public static void Del(int ID_Service)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Service service = db.Services.Where(c => c.ID == ID_Service).FirstOrDefault();
                service.DateDelete = DateTime.Today.ToString();

                db.SaveChanges();
            }
        }

    }
}
