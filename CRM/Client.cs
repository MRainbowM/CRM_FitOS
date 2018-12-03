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
    public class Client : User
    {
        //[Key, ForeignKey("client")]


        private string Surname;
        private string Name;
        private string MiddleName;
        private Int16 Sex;
        private int Height;
        private int Weight;
        private string Health;
        private string Phone;
        private DateTime DOB; //дата рождения
        private string Comment;
        private List<Photo> Photo;

        public string surname
        {
            get { return Surname; }
            private set { Surname = value; }
        }
        public string name
        {
            get
            {
                return Name;
            }
            private set
            {
                Name = value;
            }
        }
        public string middleName
        {
            get
            {
                return MiddleName;
            }
            private set
            {
                MiddleName = value;
            }
        }
        public Int16 sex
        {
            get { return Sex; }
            private set { Sex = value; }
        }
        public int height
        {
            get
            {
                return Height;
            }
            private set
            {
                Height = value;
            }
        }
        public int weight
        {
            get
            {
                return Weight;
            }
            private set
            {
                Weight = value;
            }
        }
        public string health
        {
            get
            {
                return Health;
            }
            private set
            {
                Health = value;
            }
        }
        public string phone
        {
            get
            {
                return Phone;
            }
            private set
            {
                Phone = value;
            }
        }
        public DateTime dob
        {
            get
            {
                return DOB;
            }
            private set
            {
                DOB = value;
            }
        }
        public string comment
        {
            get
            {
                return Comment;
            }
            private set
            {
                Comment = value;
            }
        }
        public List<Photo> photo
        {
            get
            {
                return Photo;
            }
            private set
            {
                Photo = value;
            }
        }

        public void Add(string f, string i, string o, bool Sex, int Height, int Weight, string Phone,string Email, DateTime DOB, string Comment, string Health,string Login, string Password)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Int16 s = 0;
                if (Sex) { s = 1; }
                db.Database.EnsureCreated();
                Client client = new Client
                {
                    Surname = f,
                    Name = i,
                    MiddleName = o,
                    Sex = s,
                    DOB = DOB,
                    Phone = Phone,
                    Comment = Comment,
                    Height = Height,
                    Email = Email,
                    Health = Health,
                    Login = Login,
                    Password = Password
                };
                db.Clients.Add(client);
                db.SaveChanges();
            }
        }

        public void Save(int ID_Client, string f, string i, string o, bool Sex, int Height, int Weight, string Phone, string Email, DateTime DOB, string Comment, string Health, string Login, string Password)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Int16 s = 0;
                if (Sex) { s = 1; } // 1 - men, 0 - women
                db.Database.EnsureCreated();
                Client client = db.Clients.Where(c => c.ID == ID_Client).FirstOrDefault();
                client.Surname = f;
                client.Name = i;
                client.MiddleName = o;
                client.Sex = s;
                client.DOB = DOB;
                client.Phone = Phone;
                client.Comment = Comment;
                client.Height = Height;
                client.Email = Email;
                client.Health = Health;
                client.Login = Login;
                client.Password = Password;




                db.SaveChanges();
            }
        }
       
        public static Client FindClientByID(int ID_Client)
        {
            ApplicationContext db = new ApplicationContext();
            Client client = db.Clients.Where(x => x.DateDelete == null && x.ID == ID_Client).FirstOrDefault();
            return client;
        }

        public static List<Client> GetAll()
        {
            ApplicationContext db = new ApplicationContext();

            List<Client> ClientList = db.Clients
                    .Where(x => x.DateDelete == null)
                    .Select(x => new Client
                    {
                        ID = x.ID,
                        Surname = x.Surname,
                        Name = x.Name,
                        MiddleName = x.MiddleName,
                        Phone = x.Phone,
                        Sex = x.sex,
                        Height = x.height,
                        Weight = x.weight,
                        Health = x.health,
                        Login = x.login,
                        Password = x.password,
                        Email = x.email,
                        DOB = x.dob,
                        Comment = x.comment
                    }).ToList();
            return ClientList;
        }

        public static void Del(int ID_Client)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Client client = db.Clients.Where(c => c.ID == ID_Client).FirstOrDefault();
                client.DateDelete = DateTime.Today.ToString();

                db.SaveChanges();
            }
        }
    }
}
