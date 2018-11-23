using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class User
    {
        protected int ID;
        protected string Login;
        protected string Password;
        protected string Email;

        public int id
        {
            get
            {
                return ID;
            }
            private set
            {
                ID = value;
            }
        }
        public string login
        {
            get
            {
                return Login;
            }
            private set
            {
                Login = value;
            }
        }
        public string password
        {
            get
            {
                return Password;
            }
            private set
            {
                Password = value;
            }
        }
        public string email
        {
            get
            {
                return Email;
            }
            private set
            {
                Email = value;
            }
        }

        public bool Del(int ID)
        {
            bool s = true;
            return s;
        }
        
        public bool Validation(string Login, string Password)
        {
            bool s = true;
            return s;
        }



    }
}
