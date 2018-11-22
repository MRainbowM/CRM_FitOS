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
    public partial class ServiceInTariff : Telerik.WinControls.UI.RadForm
    {
        public ServiceInTariff()
        {
            InitializeComponent();
        }

        private void getService_Click(object sender, EventArgs e)
        {
            SelectService selectService = new SelectService();
            selectService.Show();
        }
    }
}
