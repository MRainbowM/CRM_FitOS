using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    [Table("Cards")]
    public class Card
    {
        private int ID;
        private string N_Card;
        private int ID_User;
        private int ID_Tariff;
        private string DateOfCreation;
        private string DateDelete;

        public int id
        {
            get { return ID; }
            private set { ID = value; }
        }

        public string n_Card
        {
            get { return N_Card; }
            private set { N_Card = value; }
        }
        public int id_User
        {
            get { return ID_User; }
            private set { ID_User = value; }
        }
        public int id_Tariff
        {
            get { return ID_Tariff; }
            private set { ID_Tariff = value; }
        }
        public string dateOfCreation
        {
            get { return DateOfCreation; }
            set { DateOfCreation = value; }
        }
        public string dateDelete
        {
            get { return DateDelete; }
            private set { DateDelete = value; }
        }

        public int Add(int ID_Client, string N_Card, string Date, int ID_Tariff)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                
                db.Database.EnsureCreated();
                Card card = new Card
                {
                    ID_User = ID_Client,
                    N_Card = N_Card,
                    dateOfCreation = Date,
                    ID_Tariff = ID_Tariff
                };
                db.Cards.Add(card);
                db.SaveChanges();
                int ID_Card = card.id;
                return ID_Card;
            }
        }

        public static Card FindByID(int ID_Card)
        {
            ApplicationContext db = new ApplicationContext();
            Card card = db.Cards.Where(x => x.DateDelete == null && x.ID == ID_Card).FirstOrDefault();
            return card;
        }


        public static List<Card> GetAll()
        {
            ApplicationContext db = new ApplicationContext();

            List<Card> CardsList = db.Cards
                    .Where(x => x.DateDelete == null)
                    .Select(x => new Card
                    {
                        ID  = x.ID,
                        N_Card = x.N_Card,
                        ID_User = x.ID_User,
                        ID_Tariff = x.ID_Tariff,
                        DateOfCreation = x.DateOfCreation
                    }).ToList();
            return CardsList;
        }

        public static List<Card> GetCardByClient(int ID_Client)
        {
            ApplicationContext db = new ApplicationContext();

            List<Card> CardsList = db.Cards
                    .Where(x => x.DateDelete == null && x.ID_User == ID_Client)
                    .Select(x => new Card
                    {
                        ID = x.ID,
                        N_Card = x.N_Card,
                        ID_User = x.ID_User,
                        ID_Tariff = x.ID_Tariff,
                        DateOfCreation = x.DateOfCreation
                    }).ToList();
            return CardsList;
        }

        public static void Del(int ID_Card)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Card card = db.Cards.Where(c => c.ID == ID_Card).FirstOrDefault();
                card.DateDelete = DateTime.Today.ToString();

                db.SaveChanges();
            }
        }




        //public void Save(int ID_Card, int ID_User)
        //{
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        db.Database.EnsureCreated();
        //        Card card = db.Cards.Where(c => c.id == ID_Card).FirstOrDefault();


        //        db.SaveChanges();
        //    }
        //}



    }
}
