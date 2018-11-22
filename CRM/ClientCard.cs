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
    public partial class ClientCard : Telerik.WinControls.UI.RadForm
    {
        public ClientCard()
        {
            InitializeComponent();
        }

        private void ClientCard_Load(object sender, EventArgs e)
        {
            
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            CardCard cardCard = new CardCard();
            cardCard.Show();
        }

        private void addPay_Click(object sender, EventArgs e)
        {
            PayCard payCard = new PayCard();
            payCard.Show();
        }
    }
}
