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
    public partial class RoomCard : Telerik.WinControls.UI.RadForm
    {
        public RoomCard()
        {
            InitializeComponent();
        }

        private void addService_Click(object sender, EventArgs e)
        {
            SelectService selectService = new SelectService();
            selectService.Show();
        }

        private void delService_Click(object sender, EventArgs e)
        {
            SelectService selectService = new SelectService();
            selectService.Show();
        }
    }
}
