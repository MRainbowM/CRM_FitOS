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
    public partial class ServiceCard : Telerik.WinControls.UI.RadForm
    {
        public ServiceCard()
        {
            InitializeComponent();
        }

        public bool StateSave = false;

        private void addWorker_Click(object sender, EventArgs e)
        {
            SelectWorker selectWorker = new SelectWorker();
            selectWorker.Show();
        }

        private void del_Click(object sender, EventArgs e)
        {
            SelectWorker selectWorker = new SelectWorker();
            selectWorker.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Add(tbName.Text, Convert.ToDouble(sbCost.Value), Convert.ToInt32(sbPeople.Value), tbComment.Text);
        }

        private void ServiceCard_Load(object sender, EventArgs e)
        {
            sbCost.DecimalPlaces = 2;
            sbCost.Maximum = 100000;

            sbPeople.Maximum = 100;
            sbPeople.Minimum = 1;
        }

        private void ServiceCard_Shown(object sender, EventArgs e)
        {
            if (StateSave)
            {
                Service service = Service.FindServiceByID(RadForm1.ID_Service);
                FillForm(service);
            }
        }

        private void FillForm(Service service)
        {
            tbName.Text = service.name;
            tbComment.Text = service.comment;
            sbCost.Value = Convert.ToDecimal(service.cost);
            sbPeople.Value = service.numberOfPeople;

            StateSave = true;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Удалить клиента?",
           "Удаление клиента " + tbName.Text,
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Exclamation,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Service.Del(RadForm1.ID_Service);
            }
        }
    }
}
