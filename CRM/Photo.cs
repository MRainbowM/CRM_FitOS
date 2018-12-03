using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Photo
    {
        private int ID;
        private string URL;
        private bool State;

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
        public string url
        {
            get
            {
                return URL;
            }
            private set
            {
                URL = value;
            }
        }
        public bool state
        {
            get
            {
                return State;
            }
            private set
            {
                State = value;
            }
        }
    }
}
