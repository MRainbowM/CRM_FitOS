using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CRM
{
    public partial class Autorizatsiya : Telerik.WinControls.UI.RadForm
    {
        public Autorizatsiya()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            RadForm1 radForm1 = new RadForm1();
            this.Visible = false;
            radForm1.ShowDialog();
            this.Close();
        }
    }
}
