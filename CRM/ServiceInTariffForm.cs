using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CRM
{
    public partial class ServiceInTariffForm : Telerik.WinControls.UI.RadForm
    {
        //TariffCard tariffCard;
        public ServiceInTariffForm()
        {
            InitializeComponent();

        }

        //public int ID_Service;'
        public static string ServiceName;
        public static int Amount;
        public static int Periodicity;

            

        private void ServiceInTariff_Load(object sender, EventArgs e)
        {
            CreateCMB();
        }

        private void CreateCMB()
        {
            string ServiceN;
            string ServiceN2;
            List<Service> Services = Service.GetAll();
            for (int i = 0; i < Services.Count; i++)
            {
                ServiceN = Services[i].name;
                if (TariffCard.ServiceInGV.Count != 0)
                {
                    for (int x = 0; x < TariffCard.ServiceInGV.Count; x++)
                    {
                        ServiceN2 = TariffCard.ServiceInGV[x].name;
                        if (ServiceN != ServiceN2)
                        {
                            cmbServices.Items.Add(Services[i].name);
                        }
                    }
                }
                else
                {
                    cmbServices.Items.Add(Services[i].name);
                }
               
            }
            if (cmbServices.Items.Count == 0)
            {
                MessageBox.Show(
                "Все возможные услуги включены в тариф",
                "Ошибка добавления услуги",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                this.Close();
            }





            
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    int ID_Service;
            //    for (int i = 0; i < Services.Count; i++)
            //    {
            //        ID_Service = Services[i].id;
            //        var service = db.ServicesInTariffs
            //           .Where(x => x.DateDelete == null && x.ID_Tariff == RadForm1.ID_Tariff && x.ID_Service == ID_Service).FirstOrDefault();
            //        if (service == null)
            //        {
            //            cmbServices.Items.Add(Services[i].name);

            //        }
            //    }
            //    if (cmbServices.Items.Count == 0)
            //    {
            //       MessageBox.Show(
            //       "Все возможные услуги включены в тариф",
            //       "Ошибка добавления услуги",
            //       MessageBoxButtons.OK,
            //       MessageBoxIcon.Information,
            //       MessageBoxDefaultButton.Button1,
            //       MessageBoxOptions.DefaultDesktopOnly);
            //       this.Close();
            //    }
            //}
            //cmbServices.Enabled = false;
            cmbServices.SelectedIndex = 0;
        }

        //private int GetID(string Name)
        //{
        //    int ID = 0;
        //    List<Service> Services = Service.GetAll();
        //    for (int i = 0; i < Services.Count; i++)
        //    {
        //        if (Services[i].name == Name)
        //        {
        //            ID = Services[i].id;
        //        }
        //    }
        //    return ID;
        //}

        private void getService_Click(object sender, EventArgs e)
        {
            SelectService selectService = new SelectService();
            selectService.Show();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            ServiceName = (string)cmbServices.Text;
            Amount = (int)spAmount.Value;
            Periodicity = (int)spPeriodicity.Value;

            this.Close();

        }
    }
}
