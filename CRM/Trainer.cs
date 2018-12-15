using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    [Table("Users")]
    public class Trainer : User
    {

        Trainer(User x)
        {
            ID = x.id;
            surname = x.surname;
            name = x.name;
            middleName = x.middleName;
            phone = x.phone;
            sex = x.sex;
            Login = x.login;
            Password = x.password;
            qualification = x.qualification;
            Email = x.email;
            dob = x.dob;
            comment = x.comment;
        }
        public Trainer()
        {

        }
        //private string Surname;
        //private string Name;
        //private string MiddleName;
        //private Int16 Sex;
        //private string Qualification;
        //private string Phone;
        //private DateTime DOB; //дата рождения
        //private string Comment;
        ////private List<Photo> Photo;

        //public string surname
        //{
        //    get { return Surname; }
        //    private set { Surname = value; }
        //}
        //public string name
        //{
        //    get { return Name; }
        //    private set { Name = value; }
        //}
        //public string middleName
        //{
        //    get { return MiddleName; }
        //    private set { MiddleName = value; }
        //}
        //public Int16 sex
        //{
        //    get { return Sex; }
        //    private set { Sex = value; }
        //}
        //public string qualification
        //{
        //    get { return Qualification; }
        //    private set { Qualification = value; }
        //}
        //public string phone
        //{
        //    get { return Phone; }
        //    private set { Phone = value; }
        //}
        //public DateTime dob
        //{
        //    get { return DOB; }
        //    private set { DOB = value; }
        //}
        //public string comment
        //{
        //    get { return Comment; }
        //    private set { Comment = value; }
        //}
        ////photo


        public int Add(string f, string i, string o, bool Sex,
                       string Phone, string Qualification, string Email,
                       DateTime DOB, string Comment,
                               string Login, string Password)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Int16 s = 0;
                if (Sex) { s = 1; }
                db.Database.EnsureCreated();
                Trainer trainer = new Trainer
                {
                    surname = f,
                    name = i,
                    middleName = o,
                    sex = s,
                    dob = DOB,
                    phone = Phone,
                    StateUser = "Trainer",
                    comment = Comment,
                    qualification = Qualification,
                    Email = Email,
                    Login = Login,
                    Password = Password
                };
                db.Users.Add(trainer);
                db.SaveChanges();
                int ID_Trainer = trainer.id;
                return ID_Trainer;
            }
        }
        public void Save(int ID_Trainer, string f, string i, string o, bool Sex,
                       string Phone, string Qualification, string Email,
                       DateTime DOB, string Comment,
                       string Login, string Password)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Int16 s = 0;
                if (Sex) { s = 1; } // 1 - men, 0 - women
                db.Database.EnsureCreated();
                //Trainer trainer = new Trainer(db.Users.Where(c => c.id == ID_Trainer).FirstOrDefault());
                //trainer.surname = f;
                //trainer.name = i;
                //trainer.middleName = o;
                //trainer.sex = s;
                //trainer.dob = DOB;
                //trainer.phone = Phone;
                //trainer.comment = Comment;
                //trainer.qualification = Qualification;
                //trainer.Email = Email;
                //trainer.Login = Login;
                //trainer.Password = Password;

                User user = db.Users.Where(c => c.id == ID_Trainer).FirstOrDefault();
                user.surname = f;
                user.name = i;
                user.middleName = o;
                user.sex = s;
                user.dob = DOB;
                user.phone = Phone;
                user.comment = Comment;
                user.qualification = Qualification;
                user.email = Email;
                user.login = Login;
                user.password = Password;

                db.SaveChanges();
            }
        }

        public static Trainer FindByID(int ID_Trainer)
        {
            ApplicationContext db = new ApplicationContext();
            Trainer trainer = new Trainer(db.Users.Where(x => x.id == ID_Trainer).FirstOrDefault());
            return trainer;
        }

        public static List<Trainer> GetAll()
        {
            ApplicationContext db = new ApplicationContext();

            List<Trainer> TrainerList = db.Users
                    .Where(x => x.dateDelete == null && x.stateUser == "Trainer")
                    .Select(x => new Trainer(x)
                    ).ToList();
            return TrainerList;
        }


        //public static void Del(int ID_Trainer)
        //{
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        db.Database.EnsureCreated();
        //        Trainer trainer = FindTrainerByID(ID_Trainer);
        //        //Client client = db.User.Where(c => c.ID == ID_Client).FirstOrDefault();
        //        trainer.DateDelete = DateTime.Today.ToString();

        //        db.SaveChanges();
        //    }
        //}

    }
}
