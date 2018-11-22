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
    public partial class CardCard : Telerik.WinControls.UI.RadForm
    {
        public CardCard()
        {
            InitializeComponent();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            SelectClient selectClient = new SelectClient();
            selectClient.Show();
        }

        private void getClient_Click(object sender, EventArgs e)
        {
            ClientCard clientCard = new ClientCard();
            clientCard.Show();
        }

        private void addTariff_Click(object sender, EventArgs e)
        {
            SelectTariff selectTariff = new SelectTariff();
            selectTariff.Show();
        }

        private void freeze_Click(object sender, EventArgs e)
        {
            FreezeCard freezeCard = new FreezeCard();
            freezeCard.Show();
        }
    }
}
