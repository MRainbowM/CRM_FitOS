using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    [Table("BalanceCards")]
    public class BalanceCard
    {
        public int ID_Service { get; set; }

        public int ID_Card { get; set; }

        public int Balance { get; set; }

        public static void Add(int ID_Card, int ID_Service, int Balance)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                BalanceCard BalanceCard = new BalanceCard
                {
                    ID_Card = ID_Card,
                    ID_Service = ID_Service,
                    Balance = Balance,
                };
                db.BalanceCards.Add(BalanceCard);
                db.SaveChanges();
            }
        }

        public static List<BalanceCard> GetBalance(int ID_Card)
        {
            ApplicationContext db = new ApplicationContext();

            List<BalanceCard> BalanceCardList = db.BalanceCards
                    .Where(x =>  x.ID_Card == ID_Card)
                    .Select(x => new BalanceCard
                    {
                        ID_Card = x.ID_Card,
                        ID_Service = x.ID_Service,
                        Balance = x.Balance,
                    }
                    ).ToList();
            return BalanceCardList;
        }

    }
}
