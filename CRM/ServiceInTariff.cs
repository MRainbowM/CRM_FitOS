using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    [Table("ServiceInTariff")]
    public class ServiceInTariff
    {
        
        // Два первичных/внешних ключа в промежуточной таблице ServicesInTariff

        [Column("ID_Service"/*, ServicesInTariff = 0*/)]
        public int ID_Service { get; set; }

        //[Key, ForeignKey("Tariffs")]
        [Column("ID_Tariff"/*, ServicesInTariff = 0*/)]
        public int ID_Tariff { get; set; }

        public int Amount { get; set; }
        public int Periodicity { get; set; }
        public string DateDelete { get; set; }

        //public Tariff Tariff { get; set; }

        //public Service Service { get; set; }



        public static void Add(int ID_Tariff, int ID_Service, int Amount, int Periodicity)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                ServiceInTariff ServiceInTariff = new ServiceInTariff
                {
                    ID_Tariff = ID_Tariff,
                    ID_Service = ID_Service,
                    Amount = Amount,
                    Periodicity = Periodicity
                };
                db.ServicesInTariffs.Add(ServiceInTariff);
                db.SaveChanges();
            }
        }

        public static List<ServiceInTariff> GetServices(int ID_Tariff)
        {
            ApplicationContext db = new ApplicationContext();

            List<ServiceInTariff> ServiceInTariffList = db.ServicesInTariffs
                    .Where(x => x.DateDelete == null && x.ID_Tariff == ID_Tariff)
                    .Select(x => new ServiceInTariff
                    {
                        ID_Tariff = x.ID_Tariff,
                        ID_Service = x.ID_Service,
                        Amount = x.Amount,
                        Periodicity = x.Periodicity
                    }
                    ).ToList();
            return ServiceInTariffList;
        }

        public static void Del(int ID_Service, int ID_Tariff)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                ServiceInTariff ServiceInTariff = db.ServicesInTariffs.Where(c => c.ID_Service == ID_Service && c.ID_Tariff == ID_Tariff).FirstOrDefault();
                ServiceInTariff.DateDelete = DateTime.Today.ToString();

                db.SaveChanges();
            }
        }

    }
}
