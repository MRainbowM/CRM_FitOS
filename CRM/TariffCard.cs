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
    public partial class TariffCard : Telerik.WinControls.UI.RadForm
    {
        public TariffCard()
        {
            InitializeComponent();
        }

        public bool StateSave = false;//true - тариф уже существует, false - новый тариф

        public static List<Service> ServiceInGV = new List<Service>();




        private void TariffCard_Load(object sender, EventArgs e)
        {
            spDuration.Minimum = 0;
            spDuration.Maximum = 366;
            spTotalCost.DecimalPlaces = 2;
            spTotalCost.Minimum = 0;
            spTotalCost.Maximum = 100000;

            GVServicesInTariff.Rows.Clear();
            ServiceInTariffForm.ServiceName = "";
            ServiceInTariffForm.Amount = 0;
            ServiceInTariffForm.Periodicity = 0;

        }




        private void radGridViewCardTariff_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ServiceInTariffForm serviceInTariff = new ServiceInTariffForm();
            serviceInTariff.Show();
        }

        private void addService_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GVServicesInTariff.RowCount; i++)
            {
                ServiceInGV.Add(Service.FindByID(Convert.ToInt32(GVServicesInTariff.Rows[i].Cells[0].Value)));
            }
            
            ServiceInTariffForm serviceInTariff = new ServiceInTariffForm();
            serviceInTariff.Show();
        }

        private void delService_Click(object sender, EventArgs e)
        {
            int row = GVServicesInTariff.CurrentCell.RowIndex;
            int d = Convert.ToInt32(GVServicesInTariff.Rows[row].Cells[0].Value);

            DialogResult result = MessageBox.Show(
            "Удалить услугу " + (String)GVServicesInTariff.Rows[row].Cells[1].Value + "?",
            "Удаление услуги",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                DeleteService(d);
            }

        }

        private void DeleteService(int ID_Service)
        {
            //List<ServiceInTariff> ServiceList = new List<ServiceInTariff>();
            //for (int i = 0; i < GVServicesInTariff.RowCount; i++)
            //{
            //    if (Convert.ToInt32(GVServicesInTariff.Rows[i].Cells[0].Value) != ID_Service)
            //    {
            //        ServiceList.Add(ServiceInTariff.FindByID(Convert.ToInt32(GVServicesInTariff.Rows[i].Cells[0].Value)));
            //    }
            //}
            //GVServicesInTariff.Rows.Clear();
            //for (int i = 0; i < ServiceList.Count; i++)
            //{
            //    GVServicesInTariff.Rows.Add(ServiceList[i].id, ServiceList[i].name, RoomList[i].equipment, RoomList[i].capacity);
            //}
            //if (GVServicesInTariff.RowCount == 0)
            //{
            //    GVServicesInTariff.Visible = false;
            //}
            //var room = ServiceInRoom.FindByIDServiceAndIDRoom(ID_Room, RadForm1.ID_Service);
            //if (room != null)
            //{
            //    ServiceInRoom.Del(ID_Room, RadForm1.ID_Service);
            //}
        }









        private void TariffCard_Shown(object sender, EventArgs e)
        {
            if (StateSave)
            {
                Tariff tariff = Tariff.FindByID(RadForm1.ID_Tariff);
                FillForm(tariff);
            }
        }

        private void FillForm(Tariff tariff)
        {
            tbName.Text = tariff.name;
            spDuration.Value = tariff.duration;
            dtStartDate.Value = tariff.startDate;
            dtExpirationDate.Value = tariff.expirationDate;
            dtDateRemoved.Value = tariff.dateRemoved;
            tbComment.Text = tariff.comment;
            spTotalCost.Value = (decimal)tariff.totalCost;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SaveForm();
            }
                
        }

        private void SaveForm()
        {
            Tariff tariff = new Tariff();
            if (StateSave)
            {
                tariff.Save(RadForm1.ID_Tariff, tbName.Text, (int)spDuration.Value, (double)spTotalCost.Value, dtStartDate.Value, dtExpirationDate.Value, dtDateRemoved.Value, tbComment.Text);
            }
            else
            {
                RadForm1.ID_Tariff = tariff.Add(tbName.Text, (int)spDuration.Value, (double)spTotalCost.Value, dtStartDate.Value, dtExpirationDate.Value, dtDateRemoved.Value, tbComment.Text);
                StateSave = true;
            }
            MessageBox.Show(
            "Изменения успешно сохранены",
            "Результат сохранения",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            error.Clear();
            //this.Close();
        }

        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            if (tbName.Text == "") { error.SetError(tbName, "Заполните поле!"); message += "Название \n"; v = false; }
            if (spTotalCost.Value == 0) { error.SetError(spTotalCost, "Заполните поле!"); message += "Стоимость \n"; v = false; }
            if (spTotalCost.Value == 0) { error.SetError(spTotalCost, "Заполните поле!"); message += "Длительность тарифа \n"; v = false; }

            if (v == false)
            {
                DialogResult result = MessageBox.Show(
                "Заполните поля: " + message,
                "Ошибка сохранения!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            return v;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Удалить тариф?",
            "Удаление тарифа " + tbName.Text,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Tariff.Del(RadForm1.ID_Tariff);
            }
        }

        private void PVTariffCard_SelectedPageChanged(object sender, EventArgs e)
        {
            if (PVTariffCard.SelectedPage == pvServices)
            {
                if (StateSave)
                {
                    CreateGV();
                }
            }
        }

        //public static void AddServiceInGV(string Service, int Amount, int Periodicity)
        //{
        //    //TariffCard tariffCard = new TariffCard();

        //    ///*tariffCard.*/GVServicesInTariff.Rows.Add(Service, Amount, Periodicity);
        //}

        private void CreateGV()
        {
            List<ServiceInTariff> ServiceList = ServiceInTariff.GetServices(RadForm1.ID_Tariff);
            GVServicesInTariff.Rows.Clear();

            for (int i = 0; i <= ServiceList.Count - 1; i++)
            {
                GVServicesInTariff.Rows.Add(Service.FindByID(ServiceList[i].ID_Service).name, ServiceList[i].Amount, ServiceList[i].Periodicity);
            }
        }

        private void TariffCard_Activated(object sender, EventArgs e)
        {
            AddServiceInGV();
        }

        private void AddServiceInGV()
        {
            int p = 0;
            if (GVServicesInTariff.RowCount != 0)
            {
                for (int i = 0; i < GVServicesInTariff.RowCount; i++)
                {
                    if ((string)GVServicesInTariff.Rows[i].Cells[0].Value == ServiceInTariffForm.ServiceName && ServiceInTariffForm.ServiceName != null && ServiceInTariffForm.ServiceName != "")
                    {
                        p++;
                    }
                }
                if (p == 0)
                {
                    GVServicesInTariff.Rows.Add(ServiceInTariffForm.ServiceName, ServiceInTariffForm.Amount, ServiceInTariffForm.Periodicity);
                }
            }

            else
            {
                if (ServiceInTariffForm.ServiceName != null && ServiceInTariffForm.ServiceName != "")
                {
                    GVServicesInTariff.Rows.Add(ServiceInTariffForm.ServiceName, ServiceInTariffForm.Amount, ServiceInTariffForm.Periodicity);
                }
            }
           
        }


        private void btnSaveService_Click(object sender, EventArgs e)
        {
            SaveServices();
        }
        private void SaveServices()
        {
            if (Validation())
            {
                SaveForm();
                using (ApplicationContext db = new ApplicationContext())
                {
                    int ID_Service;
                    int Amount;
                    int Periodicity;
                    for (int i = 0; i < GVServicesInTariff.RowCount; i++)
                    {
                        ID_Service = Service.FindIDByName((string)GVServicesInTariff.Rows[i].Cells[0].Value);
                        Amount = Convert.ToInt32((string)GVServicesInTariff.Rows[i].Cells[1].Value);
                        Periodicity = Convert.ToInt32((string)GVServicesInTariff.Rows[i].Cells[2].Value);
                        var service = db.ServicesInTariffs
                        .Where(x => x.DateDelete == null && x.ID_Tariff == RadForm1.ID_Tariff && x.ID_Service == ID_Service).FirstOrDefault();
                        if (service == null)
                        {
                            ServiceInTariff.Add(RadForm1.ID_Tariff, ID_Service, Amount, Periodicity);
                        }

                    }
                }
               
            }
           
        }
    }
}
