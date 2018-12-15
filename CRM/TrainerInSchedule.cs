using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class TrainerInSchedule
    {
        public int ID_Trainer { get; set; }
        public int ID_Schedule { get; set; }

        public static void Add(int ID_Trainer, int ID_Schedule)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                db.Database.EnsureCreated();
                TrainerInSchedule TrainerInSchedule = new TrainerInSchedule
                {
                    ID_Trainer = ID_Trainer,
                    ID_Schedule = ID_Schedule
                };
                db.TrainersInSchedule.Add(TrainerInSchedule);
                db.SaveChanges();
            }
        }

        public static List<TrainerInSchedule> FindByIDTrainer(int ID_Trainer)
        {
            ApplicationContext db = new ApplicationContext();
            List<TrainerInSchedule> TrainerInSchedule = db.TrainersInSchedule
                    .Where(x => x.ID_Trainer == ID_Trainer)
                    .Select(x => new TrainerInSchedule
                    {
                        ID_Trainer = x.ID_Trainer,
                        ID_Schedule = x.ID_Schedule
                    }
                    ).ToList();
            return TrainerInSchedule;
        }


        public static List<TrainerInSchedule> FindByIDSchedule(int ID_Schedule)
        {
            ApplicationContext db = new ApplicationContext();
            List<TrainerInSchedule> TrainerInSchedule = db.TrainersInSchedule
                    .Where(x => x.ID_Schedule == ID_Schedule)
                    .Select(x => new TrainerInSchedule
                    {
                        ID_Trainer = x.ID_Trainer,
                        ID_Schedule = x.ID_Schedule
                    }
                    ).ToList();
            return TrainerInSchedule;
        }


        public static void Del(int ID_Schedule, int ID_Trainer)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                TrainerInSchedule TrainerInSchedule = db.TrainersInSchedule.Where(c => c.ID_Schedule == ID_Schedule && c.ID_Trainer == ID_Trainer).FirstOrDefault();

                db.TrainersInSchedule.Remove(TrainerInSchedule);
                db.SaveChanges();
            }
        }



    }
}
