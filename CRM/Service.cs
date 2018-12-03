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
        private double Cost;
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
        public double cost
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




        public void Add(string Name, double Cost, int NumberOfPeople, string Comment)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Service service = new Service
                {
                    Name = Name,
                    Cost = Cost,
                    NumberOfPeople = NumberOfPeople,
                    Comment = Comment
                };
                db.Services.Add(service);
                db.SaveChanges();
            }
        }

        public static Service FindServiceByID(int ID_Service)
        {
            ApplicationContext db = new ApplicationContext();
            Service service = db.Services.Where(x => x.DateDelete == null && x.ID == ID_Service).FirstOrDefault();
            return service;
        }

        public static List<Service> GetAll()
        {
            ApplicationContext db = new ApplicationContext();

            List<Service> ServiceList = db.Services
                    .Where(x => x.DateDelete == null  /*x.ID == 6*/)
                    .Select(x => new Service
                    {
                        ID = x.ID,
                        Name = x.Name,
                        Comment = x.comment,
                        Cost = x.Cost,
                        NumberOfPeople = x.NumberOfPeople
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
