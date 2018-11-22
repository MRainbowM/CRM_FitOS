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
    public partial class SelectTariff : Telerik.WinControls.UI.RadForm
    {
        public SelectTariff()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchTariff searchTariff = new SearchTariff();
            searchTariff.Show();
        }
    }
}
