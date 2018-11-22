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
    public partial class ServiceCard : Telerik.WinControls.UI.RadForm
    {
        public ServiceCard()
        {
            InitializeComponent();
        }

        private void addWorker_Click(object sender, EventArgs e)
        {
            SelectWorker selectWorker = new SelectWorker();
            selectWorker.Show();
        }

        private void del_Click(object sender, EventArgs e)
        {
            SelectWorker selectWorker = new SelectWorker();
            selectWorker.Show();
        }
    }
}
