using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class User
    {
        //[Key]
        protected int ID;
        protected string Login;
        protected string Password;
        protected string Email;
        private string Surname;
        private string Name;
        private string MiddleName;
        private Int16 Sex;
        private string Phone;
        private DateTime DOB; //дата рождения
        private string Comment;
        protected string DateDelete;

        private int Height; //client
        private int Weight;//client
        private string Health;//client

        private string Qualification;//trainer

        protected string StateUser;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string login
        {
            get { return Login; }
            set { Login = value; }
        }
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string surname
        {
            get { return Surname; }
            set { Surname = value; }
        }
        public string name
        {
            get
            {
                return Name;
            }
            set
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
            set
            {
                MiddleName = value;
            }
        }
        public Int16 sex
        {
            get { return Sex; }
            set { Sex = value; }
        }
        public string phone
        {
            get { return Phone; }
            set { Phone = value; }
        }
        public DateTime dob
        {
            get { return DOB; }
            set { DOB = value; }
        }
        public string comment
        {
            get { return Comment; }
            set { Comment = value; }
        }
        public string dateDelete
        {
            get { return DateDelete; }
            set { DateDelete = value; }
        }

        public int height
        {
            get
            {
                return Height;
            }
            set
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
            set
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
            set
            {
                Health = value;
            }
        }
       
        public string qualification
        {
            get { return Qualification; }
            set { Qualification = value; }
        }
        
        public string stateUser
        {
            get { return StateUser; }
            set { StateUser = value; }
        }
        


        public bool Validation(string Login, string Password)
        {
            bool s = true;
            return s;
        }

        public static void Del(int ID)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                User user = db.Users.Where(c => c.ID == ID).FirstOrDefault();
                user.DateDelete = DateTime.Today.ToString();

                db.SaveChanges();
            }
        }



    }
}
