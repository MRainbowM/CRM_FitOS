using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class ScheduleService
    {
        public int ID { get; set; }
        public int ID_Service { get; set; }
        public int ID_Room { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Cost { get; set; }
        public int Duration { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DateDelete { get; set; }

        public int Add(int ID_Service, int ID_Room, DateTime Date, int NumberOfPeople, int Duration, decimal Cost)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                db.Database.EnsureCreated();
                ScheduleService ScheduleService = new ScheduleService
                {
                    ID_Service = ID_Service,
                    ID_Room = ID_Room,
                    Date = Date,
                    NumberOfPeople = NumberOfPeople,
                    Duration = Duration,
                    Cost = Cost
                };
                db.ScheduleServices.Add(ScheduleService);
                db.SaveChanges();
                int ID = ScheduleService.ID;
                return ID;
            }
        }

        public void Save(int ID_Schedule, int NumberOfPeople, decimal Cost)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                ScheduleService ScheduleService = db.ScheduleServices.Where(c => c.ID == ID_Schedule).FirstOrDefault();
                ScheduleService.NumberOfPeople = NumberOfPeople;
                ScheduleService.Cost = Cost;

                db.SaveChanges();
            }
        }


        //public void FreezeCard()
        //{
        //    using (ApplicationContext db = new ApplicationContext())
        //    {

        //        db.Database.EnsureCreated();
        //        ScheduleService ScheduleService = new ScheduleService
        //        {
        //            ID_Service = ID_Service,
        //            ID_Room = ID_Room,
        //            Date = Date,
        //        };
        //        db.ScheduleServices.Add(ScheduleService);
        //        db.SaveChanges();
        //        int ID = ScheduleService.ID;
        //        return ID;
        //    }
        //}

        //public static ScheduleService FindByID(int ID_Card)
        //{
        //    ApplicationContext db = new ApplicationContext();
        //    Card card = db.Cards.Where(x => x.DateDelete == null && x.ID == ID_Card).FirstOrDefault();
        //    return card;
        //}

        public static ScheduleService FindByID(int ID_Schedule)
        {
            ApplicationContext db = new ApplicationContext();
            ScheduleService ScheduleService = db.ScheduleServices.Find(ID_Schedule);
            return ScheduleService;
        }



        public static List<ScheduleService> GetAll()
        {
            ApplicationContext db = new ApplicationContext();

            List<ScheduleService> ScheduleServiceList = db.ScheduleServices
                    .Where(x => x.DateDelete == null) /*&& x.Date > DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0)))*/
                    .Select(x => new ScheduleService
                    {
                        ID = x.ID,
                        ID_Service = x.ID_Service,
                        ID_Room = x.ID_Room,
                        Date = x.Date,
                        NumberOfPeople = x.NumberOfPeople,
                        Duration = x.Duration,
                        Cost = x.Cost
                    }).ToList();
            return ScheduleServiceList;
        }
    }
}
