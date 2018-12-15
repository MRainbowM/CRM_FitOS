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
    public partial class SelectClient : Telerik.WinControls.UI.RadForm
    {
        public SelectClient()
        {
            InitializeComponent();
        }

        //public static bool StateAdd = false;// истина - если объекты добавляются, ложь - если удаляются

        public static Client ClientSelect;

        private void search_Click(object sender, EventArgs e)
        {
            SearchClients searchClients = new SearchClients();
            searchClients.Show();
        }

        //private void del_Click(object sender, EventArgs e)
        //{
        //    SearchClients searchClients = new SearchClients();
        //    searchClients.Show();
        //}

        private void SelectClient_Load(object sender, EventArgs e)
        {
            CreateGV();
        }

        private void CreateGV()
        {
            List<Client> ClientsList = Client.GetAll();
            GVClients.Rows.Clear();

            for (int i = 0; i <= ClientsList.Count - 1; i++)
            {
                GVClients.Rows.Add(ClientsList[i].id, ClientsList[i].surname, ClientsList[i].name, ClientsList[i].middleName);
            }
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ClientSelect = new Client();
            int row = GVClients.CurrentCell.RowIndex;
            int d = Convert.ToInt32(GVClients.Rows[row].Cells[0].Value);
            ClientSelect = Client.FindByID(Convert.ToInt32(d));
            this.Close();


            //ClientSelect = new Client();
            //for (int i = 0; i < GVClients.RowCount; i++)
            //{
            //    if (GVClients.Rows[i].Cells[4].Value != null)
            //    {
            //        ClientSelect = Client.FindByID(Convert.ToInt32((string)GVClients.Rows[i].Cells[0].Value));
            //        //TrainerCard.ServiceInTariffList.Add(id (int)GVServices.Rows[i].Cells[0].Value, (string)GVServices.Rows[i].Cells[1].Value);
            //        //ServiceList.Add(service);
            //    }
            //}
            //this.Close();
        }
    }
}
