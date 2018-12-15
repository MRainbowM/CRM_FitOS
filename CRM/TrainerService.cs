using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    [Table("TrainerServices")]
    public class TrainerService
    {
        [Column("ID_Service"/*, ServicesInTariff = 0*/)]
        public int ID_Service { get; set; }

        [Column("ID_Trainer"/*, ServicesInTariff = 0*/)]
        public int ID_Trainer { get; set; }


        public static void Add(int ID_Trainer, int ID_Service)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                TrainerService TrainerService = new TrainerService
                {
                    ID_Service = ID_Service,
                    ID_Trainer = ID_Trainer
                };
                db.TrainerServices.Add(TrainerService);
                db.SaveChanges();
            }
        }

        public static List<TrainerService> GetServices(int ID_Trainer)
        {
            ApplicationContext db = new ApplicationContext();

            List<TrainerService> TrainerServiceList = db.TrainerServices
                    .Where(x =>  x.ID_Trainer == ID_Trainer)
                    .Select(x => new TrainerService
                    {
                        ID_Service = x.ID_Service
                    }
                    ).ToList();
            return TrainerServiceList;
        }

        public static List<TrainerService> GetTrainers(int ID_Service)
        {
            ApplicationContext db = new ApplicationContext();

            List<TrainerService> TrainerServiceList = db.TrainerServices
                    .Where(x => x.ID_Service == ID_Service)
                    .Select(x => new TrainerService
                    {
                        ID_Trainer = x.ID_Trainer
                    }
                    ).ToList();
            return TrainerServiceList;
        }

        public static void Del(int ID_Service, int ID_Trainer)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                TrainerService TrainerService = db.TrainerServices.Where(c => c.ID_Service == ID_Service && c.ID_Trainer == ID_Trainer).FirstOrDefault();

                db.TrainerServices.Remove(TrainerService);
                db.SaveChanges();
            }
        }



    }
}
