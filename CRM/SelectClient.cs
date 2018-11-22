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
    public partial class SelectClient : Telerik.WinControls.UI.RadForm
    {
        public SelectClient()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchClients searchClients = new SearchClients();
            searchClients.Show();
        }

        private void del_Click(object sender, EventArgs e)
        {
            SearchClients searchClients = new SearchClients();
            searchClients.Show();
        }
    }
}
