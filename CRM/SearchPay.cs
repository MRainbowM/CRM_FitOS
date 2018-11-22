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
    public partial class SearchPay : Telerik.WinControls.UI.RadForm
    {
        public SearchPay()
        {
            InitializeComponent();
        }

        private void selectService_Click(object sender, EventArgs e)
        {
            SelectService selectService = new SelectService();
            selectService.Show();
        }

        private void selectClient_Click(object sender, EventArgs e)
        {
            SelectClient selectClient = new SelectClient();
            selectClient.Show();
        }
    }
}
