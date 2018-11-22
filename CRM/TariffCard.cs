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
    public partial class TariffCard : Telerik.WinControls.UI.RadForm
    {
        public TariffCard()
        {
            InitializeComponent();
        }


        private void radGridViewCardTariff_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ServiceInTariff serviceInTariff = new ServiceInTariff();
            serviceInTariff.Show();
        }

        private void addService_Click(object sender, EventArgs e)
        {
            ServiceInTariff serviceInTariff = new ServiceInTariff();
            serviceInTariff.Show();
        }

        private void delService_Click(object sender, EventArgs e)
        {
            ServiceInTariff serviceInTariff = new ServiceInTariff();
            serviceInTariff.Show();
        }
    }
}
