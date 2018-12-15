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
    public partial class SelectTariff : Telerik.WinControls.UI.RadForm
    {
        public SelectTariff()
        {
            InitializeComponent();
        }

        public static Tariff TariffSelect;

        private void SelectTariff_Load(object sender, EventArgs e)
        {
            CreateGV();
        }

        private void CreateGV()
        {
            GVTariffs.Rows.Clear();
            List<Tariff> Tariffs = Tariff.GetAll();
            for (int i = 0; i <= Tariffs.Count - 1; i++)// создание таблицы с УСЛУГАМИ
            {
                GVTariffs.Rows.Add(Tariffs[i].id, Tariffs[i].name, Tariffs[i].totalCost/*, Services[i].numberOfPeople*/);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchTariff searchTariff = new SearchTariff();
            searchTariff.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            TariffSelect = new Tariff();
            int row = GVTariffs.CurrentCell.RowIndex;
            int d = Convert.ToInt32(GVTariffs.Rows[row].Cells[0].Value);
            TariffSelect = Tariff.FindByID(Convert.ToInt32(d));
            this.Close();
        }
    }
}
