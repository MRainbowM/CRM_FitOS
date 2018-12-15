using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace CRM
{
    public partial class SelectService : Telerik.WinControls.UI.RadForm
    {
        public SelectService()
        {
            InitializeComponent();
        }

        public static List<Service> ServiceInGV = new List<Service>(); //услуги, которые уже есть в таблице

        public static List<Service> ServiceList = new List<Service>(); //лист для добавления услуг 

        public bool ManyServices = true;

        public static Service SelectOneService;

        private void search_Click(object sender, EventArgs e)
        {
            SearchService searchService = new SearchService();
            searchService.Show();
        }

        private void SelectService_Load(object sender, EventArgs e)
        {
            //GVServices.SelectedCells[3].EditMode = EditMode.OnValueChange;
            //GVServices.SelectedCells[3].
            CreateGV();
            if (!ManyServices)
            {
                GVServices.Columns[3].IsVisible = false;
            }
        }

        private void CreateGV()
        {
            GVServices.Rows.Clear();
            int p = 0;
            List<Service> Services = Service.GetAll();
            for (int i = 0; i <= Services.Count - 1; i++)// создание таблицы с УСЛУГАМИ
            {
                for (int x = 0; x < ServiceInGV.Count; x++)
                {
                    if (Services[i].id == ServiceInGV[x].id)
                    {
                        p++;
                    }
                }
                if (p == 0)
                {
                    GVServices.Rows.Add(Services[i].id, Services[i].name, Services[i].cost/*, Services[i].numberOfPeople*/);
                }
                p = 0;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!ManyServices)
            {
                SelectOneService = new Service();
                int row = GVServices.CurrentCell.RowIndex;
                int d = Convert.ToInt32(GVServices.Rows[row].Cells[0].Value);
                SelectOneService = Service.FindByID(Convert.ToInt32(d));
            }
            else
            {
                ServiceList.Clear();
                Service service = new Service();
                for (int i = 0; i < GVServices.RowCount; i++)
                {
                    if (GVServices.Rows[i].Cells[3].Value != null)
                    {
                        service = Service.FindByID(Convert.ToInt32((string)GVServices.Rows[i].Cells[0].Value));
                        ServiceList.Add(service);
                    }
                }
            }
            ManyServices = true;
            ServiceInGV.Clear();
            this.Close();
        }

    }
}
