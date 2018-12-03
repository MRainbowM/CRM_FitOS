using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    //[Table("User")]
    public class Trainer : User
    {

        private string Surname;
        private string Name;
        private string MiddleName;
        private Int16 Sex;
        private string Qualification;
        private string Phone;
        private DateTime DOB; //дата рождения
        private string Comment;
        //private List<Photo> Photo;

        public string surname
        {
            get { return Surname; }
            private set { Surname = value; }
        }
        public string name
        {
            get { return Name; }
            private set { Name = value; }
        }
        public string middleName
        {
            get { return MiddleName; }
            private set { MiddleName = value; }
        }
        public Int16 sex
        {
            get { return Sex; }
            private set { Sex = value; }
        }
        public string qualification
        {
            get { return Qualification; }
            private set { Qualification = value; }
        }
        public string phone
        {
            get { return Phone; }
            private set { Phone = value; }
        }
        public DateTime dob
        {
            get { return DOB; }
            private set { DOB = value; }
        }
        public string comment
        {
            get { return Comment; }
            private set { Comment = value; }
        }
        //////photo
        

        public void Add(string f, string i, string o, bool Sex,
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
                    Surname = f,
                    Name = i,
                    MiddleName = o,
                    Sex = s,
                    DOB = DOB,
                    Phone = Phone,
                    //StateUser = "Тренер",
                    Comment = Comment,
                    Qualification = Qualification,
                    Email = Email,
                    Login = Login,
                    Password = Password
                };
                db.Trainers.Add(trainer);
                db.SaveChanges();
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
                Trainer trainer = db.Trainers.Where(c => c.ID == ID_Trainer).FirstOrDefault();
                trainer.Surname = f;
                trainer.Name = i;
                trainer.MiddleName = o;
                trainer.Sex = s;
                trainer.DOB = DOB;
                trainer.Phone = Phone;
                trainer.Comment = Comment;
                trainer.Qualification = Qualification;
                trainer.Email = Email;
                trainer.Login = Login;
                trainer.Password = Password;

                db.SaveChanges();
            }
        }

        public static Trainer FindClientByID(int ID_Trainer)
        {
            ApplicationContext db = new ApplicationContext();
            Trainer trainer = db.Trainers.Where(x => x.DateDelete == null && x.ID == ID_Trainer).FirstOrDefault();
            return trainer;
        }

        public static List<Trainer> GetAll()
        {
            ApplicationContext db = new ApplicationContext();

            List<Trainer> TrainerList = db.Trainers
                    .Where(x => x.DateDelete == null)
                    .Select(x => new Trainer
                    {
                        ID = x.ID,
                        Surname = x.surname,
                        Name = x.name,
                        MiddleName = x.middleName,
                        Phone = x.Phone,
                        Sex = x.sex,
                        Login = x.login,
                        Password = x.password,
                        Qualification = x.qualification,
                        Email = x.email,
                        DOB = x.dob,
                        Comment = x.comment
                    }).ToList();
            return TrainerList;
        }

    }
}
