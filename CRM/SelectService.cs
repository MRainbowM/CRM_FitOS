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
    public partial class SelectService : Telerik.WinControls.UI.RadForm
    {
        public SelectService()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchService searchService = new SearchService();
            searchService.Show();
        }
    }
}
