using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    [Table("Users")]
    public class Client : User
    {
        Client(User x)
        {
            ID = x.id;
            surname = x.surname;
            name = x.name;
            middleName = x.middleName;
            phone = x.phone;
            sex = x.sex;
            Login = x.login;
            Password = x.password;
            Email = x.email;
            dob = x.dob;
            comment = x.comment;
            height = x.height;
            weight= x.weight;
            health = x.health;
        }
        public Client()
        {

        }

        //private string Surname;
        //private string Name;
        //private string MiddleName;
        //private Int16 Sex;
        //private int Height;
        //private int Weight;
        //private string Health;
        //private string Phone;
        //private DateTime DOB; //дата рождения
        //private string Comment;
        //private List<Photo> Photo;

        //public string surname
        //{
        //    get { return Surname; }
        //    private set { Surname = value; }
        //}
        //public string name
        //{
        //    get
        //    {
        //        return Name;
        //    }
        //    private set
        //    {
        //        Name = value;
        //    }
        //}
        //public string middleName
        //{
        //    get
        //    {
        //        return MiddleName;
        //    }
        //    private set
        //    {
        //        MiddleName = value;
        //    }
        //}
        //public Int16 sex
        //{
        //    get { return Sex; }
        //    private set { Sex = value; }
        //}
        //public int height
        //{
        //    get
        //    {
        //        return Height;
        //    }
        //    private set
        //    {
        //        Height = value;
        //    }
        //}
        //public int weight
        //{
        //    get
        //    {
        //        return Weight;
        //    }
        //    private set
        //    {
        //        Weight = value;
        //    }
        //}
        //public string health
        //{
        //    get
        //    {
        //        return Health;
        //    }
        //    private set
        //    {
        //        Health = value;
        //    }
        //}
        //public string phone
        //{
        //    get
        //    {
        //        return Phone;
        //    }
        //    private set
        //    {
        //        Phone = value;
        //    }
        //}
        //public DateTime dob
        //{
        //    get
        //    {
        //        return DOB;
        //    }
        //    private set
        //    {
        //        DOB = value;
        //    }
        //}
        //public string comment
        //{
        //    get
        //    {
        //        return Comment;
        //    }
        //    private set
        //    {
        //        Comment = value;
        //    }
        //}
        //public List<Photo> photo
        //{
        //    get
        //    {
        //        return Photo;
        //    }
        //    private set
        //    {
        //        Photo = value;
        //    }
        //}

        public int Add(string f, string i, string o, bool Sex, int Height, int Weight, string Phone, string Email, DateTime DOB, string Comment, string Health, string Login, string Password)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Int16 s = 0;
                if (Sex) { s = 1; }
                db.Database.EnsureCreated();
                Client client = new Client()
                {
                    surname = f,
                    name = i,
                    middleName = o,
                    sex = s,
                    dob = DOB,
                    phone = Phone,
                    comment = Comment,
                    StateUser = "Client",
                    height = Height,
                    email = Email,
                    health = Health,
                    login = Login,
                    password = Password
                };
                db.Users.Add(client);
                db.SaveChanges();
                int ID_Client = client.id;
                return ID_Client;
            }
        }

        public void Save(int ID_Client, string f, string i, string o, bool Sex, int Height, int Weight, string Phone, string Email, DateTime DOB, string Comment, string Health, string Login, string Password)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Int16 s = 0;
                if (Sex) { s = 1; } // 1 - men, 0 - women
                db.Database.EnsureCreated();
                //Client client = new Client(db.Users.Where(c => c.id == ID_Client).FirstOrDefault());
                //client.surname = f;
                //client.name = i;
                //client.middleName = o;
                //client.sex = s;
                //client.dob = DOB;
                //client.phone = Phone;
                //client.comment = Comment;
                //client.height = Height;
                //client.email = Email;
                //client.health = Health;
                //client.login = Login;
                //client.password = Password;


                User user = db.Users.Where(c => c.id == ID_Client).FirstOrDefault();
                user.surname = f;
                user.name = i;
                user.middleName = o;
                user.sex = s;
                user.dob = DOB;
                user.phone = Phone;
                user.comment = Comment;
                user.height = Height;
                user.email = Email;
                user.health = Health;
                user.login = Login;
                user.password = Password;

                db.SaveChanges();
            }
        }

        public static Client FindByID(int ID_Client)
        {
            ApplicationContext db = new ApplicationContext();
            Client client = new Client(db.Users.Where(x => x.dateDelete == null && x.id == ID_Client).FirstOrDefault());
            return client;
        }

        public static List<Client> GetAll()
        {
            ApplicationContext db = new ApplicationContext();

            List<Client> ClientList = db.Users
                    .Where(x => x.dateDelete == null && x.stateUser == "Client")
                    .Select(x => new Client(x)).ToList();
            return ClientList;
        }

        //public static void Del(int ID_Client)
        //{
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        db.Database.EnsureCreated();
        //        Client client = FindClientByID(ID_Client);
        //        //Client client = db.User.Where(c => c.ID == ID_Client).FirstOrDefault();
        //        client.DateDelete = DateTime.Today.ToString();

        //        db.SaveChanges();
        //    }
        //}
    }
}
