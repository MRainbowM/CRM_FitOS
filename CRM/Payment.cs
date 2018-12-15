using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Payment
    {
        public int ID { get; set; }
        public int ID_Card { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfPayment { get; set; }
        public decimal Amount { get; set; }
        public decimal Paid { get; set; }
        public int ID_Reservation { get; set; }
        public int ID_User { get; set; }

        //public int Add(int ID_User, int ID_Reservation, decimal Amount)
        //{
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        //Int16 s = 0;
        //        //if (Sex) { s = 1; }
        //        //db.Database.EnsureCreated();
        //        //Trainer trainer = new Trainer
        //        //{
        //        //    surname = f,
        //        //    name = i,
        //        //    middleName = o,
        //        //    sex = s,
        //        //    dob = DOB,
        //        //    phone = Phone,
        //        //    StateUser = "Trainer",
        //        //    comment = Comment,
        //        //    qualification = Qualification,
        //        //    Email = Email,
        //        //    Login = Login,
        //        //    Password = Password
        //        //};
        //        //db.Users.Add(trainer);
        //        //db.SaveChanges();
        //        //int ID_Trainer = trainer.id;
        //        //return ID_Trainer;
        //    }
        //}

    }
}
