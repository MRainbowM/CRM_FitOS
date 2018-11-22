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
    public partial class SelectWorker : Telerik.WinControls.UI.RadForm
    {
        public SelectWorker()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchWorker searchWorker = new SearchWorker();
            searchWorker.Show();
        }
    }
}
