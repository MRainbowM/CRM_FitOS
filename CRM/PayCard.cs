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
    public partial class PayCard : Telerik.WinControls.UI.RadForm
    {
        public PayCard()
        {
            InitializeComponent();
        }

        private void selectClient_Click(object sender, EventArgs e)
        {
            SelectClient selectClient = new SelectClient();
            selectClient.Show();
        }
    }
}
