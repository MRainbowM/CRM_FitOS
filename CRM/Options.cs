using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    [Table ("Options")]
    public class Options
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public void Add()
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                db.Database.EnsureCreated();
                Options Options = new Options
                {
                    Name = Name,
                    Value = Value
                };
                db.Options.Add(Options);
                db.SaveChanges();
                //int ID_Card = card.id;
                //return ID_Card;
            }
        }

        public static void Save(int ID_Option, string Name, string Value)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Options Options = db.Options.Where(c => c.ID == ID_Option).FirstOrDefault();
                Options.Name = Name;
                Options.Value = Value;
                db.SaveChanges();
            }
        }

        public static Options FindByID(int ID_Option)
        {
            ApplicationContext db = new ApplicationContext();
            Options Options = db.Options.Where(x =>  x.ID == ID_Option).FirstOrDefault();
            return Options;
        }
    }
}
