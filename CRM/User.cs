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
        //protected string StateUser;
        protected string DateDelete;

        public int id
        {
            get { return ID; }
            private set { ID = value; }
        }
        public string login
        {
            get { return Login; }
            private set { Login = value; }
        }
        public string password
        {
            get {return Password;}
            private set{Password = value;}
        }
        public string email
        {
            get { return Email; }
            private set { Email = value; }
        }
        //public string stateUser
        //{
        //    get { return StateUser; }
        //    private set { StateUser = value; }
        //}
        public string dateDelete
        {
            get { return DateDelete; }
            private set { DateDelete = value; }
        }


        
        public bool Validation(string Login, string Password)
        {
            bool s = true;
            return s;
        }

        


    }
}
