using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class проверка_подключения : Form
    {
        public проверка_подключения()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Us user1 = new Us { Name = "SSSSSSSSSSS"/*, Age = 33 */};
                Us user2 = new Us { Name = "AAAAAAAAA", Age = 26 };
                //db.Usdd.Add(user1);
                //db.Usdd.Add(user2);
                db.SaveChanges();
                label1.Text = "norm";

                //var usdd = db.Usdd.ToList();
                //foreach (Us u in usdd)
                {
                    //comboBox1.Text = u.Name;
                }

            }
        }
       
       
            
        
        
    }
}
