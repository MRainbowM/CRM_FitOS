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
    public partial class OptionsForm : Telerik.WinControls.UI.RadForm
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btnWay_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(FBD.SelectedPath);
                tbWayPhoto.Text = FBD.SelectedPath;
            }
            Options.Save(1, "WayToPhoto", FBD.SelectedPath);
        }
    }
}
