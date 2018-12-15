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

        public bool StateSave = false;
        public static int ID_Client;
        public static int ID_Tariff;

        private void CardCard_Load(object sender, EventArgs e)
        {
            dtDateOfCreation.Enabled = false;
            tbTariff.Enabled = false;
            tbIDCard.MaxLength = 16;
            tbRestOfDays.Enabled = false;
            dtTariffEnd.Enabled = false;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            if (StateSave)
            {
                Card card = Card.FindByID(RadForm1.ID_Card);
                FillForm(card);
                getClient.Visible = true;
                tbIDCard.Enabled = false;
                updateTariff.Visible = true;
                addTariff.Visible = false;
            }
            else
            {
                dtDateOfCreation.Value = DateTime.Today;
                getClient.Visible = false;
                getTariff.Visible = false;
                updateTariff.Visible = false;

                if (ID_Client != 0)
                {
                    tbSurname.Text = Client.FindByID(ID_Client).surname;
                    tbName.Text = Client.FindByID(ID_Client).name;
                    tbMiddleName.Text = Client.FindByID(ID_Client).middleName;
                    addClient.Visible = false;
                }
            }
            
        }

        private void FillForm(Card card)
        {
            tbIDCard.Text = card.n_Card.ToString();
            tbSurname.Text = Client.FindByID(card.id_User).surname;
            tbName.Text = Client.FindByID(card.id_User).name;
            tbMiddleName.Text = Client.FindByID(card.id_User).middleName;

            ID_Client = Client.FindByID(card.id_User).id;

            tbTariff.Text = Tariff.FindByID(card.id_Tariff).name;
            dtDateOfCreation.Value = Convert.ToDateTime(card.dateOfCreation);

            ID_Tariff = card.id_Tariff;

            dtTariffEnd.Value = Convert.ToDateTime(card.dateOfCreation).AddDays(Tariff.FindByID(card.id_Tariff).duration);
            tbRestOfDays.Text = Convert.ToString((dtTariffEnd.Value - DateTime.Today).TotalDays);

            CreateGV1();

            string WayDir1 = Options.FindByID(1).Value + "/";
            if (Photo.FindByIDUser(ID_Client) != null)
            {
                string NamePhoto1 = Photo.FindByIDUser(ID_Client).Name;
                string a = WayDir1 + NamePhoto1;
                pictureBox1.Image = Image.FromFile(a);
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            SelectClient selectClient = new SelectClient();
            selectClient.ShowDialog();
            RefreshCard();

        }

        private void getClient_Click(object sender, EventArgs e)
        {
            ClientCard clientCard = new ClientCard();
            clientCard.StateSave = true;
            RadForm1.ID_Client = ID_Client;
            clientCard.ShowDialog();
            RefreshCard();
        }

        private void addTariff_Click(object sender, EventArgs e)
        {
            SelectTariff selectTariff = new SelectTariff();
            updateTariff.Visible = true; //сменить тариф
            addTariff.Visible = false; //добавить тариф
            getTariff.Visible = true; //посмотреть тариф
            selectTariff.ShowDialog();
            RefreshCard();
        }

        private void freeze_Click(object sender, EventArgs e)
        {
            FreezeCard freezeCard = new FreezeCard();
            freezeCard.ShowDialog();
            RefreshCard();
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
            Card card = new Card();
            if (StateSave)
            {
                //card.Save(RadForm1.ID_Service, tbName.Text, Convert.ToInt32(spCost.Value), Convert.ToInt32(spPeople.Value), tbComment.Text);
            }
            else
            {
                RadForm1.ID_Card = card.Add(ID_Client, tbIDCard.Text, dtDateOfCreation.Value.ToString(), ID_Tariff);
                int ID_Card = RadForm1.ID_Card;
                AddServicesInBalanceCard(ID_Tariff, ID_Card);
            }
            MessageBox.Show(
            "Изменения успешно сохранены",
            "Результат сохранения",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);


            StateSave = true;
            error.Clear();

        }

        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            if (tbIDCard.Text == "") { error.SetError(tbIDCard, "Заполните поле!"); message += "Номер карты \n"; v = false; }
            if (tbName.Text == "") { error.SetError(addClient, "Добавьте владельца карты!"); message += "Владелец карты \n"; v = false; }
            if (tbTariff.Text == "") { error.SetError(addTariff, "Добавьте тариф !"); message += "Добавьте тариф \n"; v = false; }
            //if (spPeople.Value == 0) { error.SetError(spPeople, "Заполните поле!"); message += "Вместимость услуги \n"; v = false; }

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
      
        private void RefreshCard()
        {
            if (SelectClient.ClientSelect != null && SelectClient.ClientSelect.name != null)
            {
                AddClient();
            }
            if (SelectTariff.TariffSelect != null && SelectTariff.TariffSelect.name != null)
            {
                AddTariff();
                dtTariffEnd.Value = Convert.ToDateTime(dtDateOfCreation.Value).AddDays(Tariff.FindByID(ID_Tariff).duration);
                tbRestOfDays.Text = Convert.ToString((dtTariffEnd.Value - DateTime.Today).TotalDays);
                getTariff.Visible = false;
            }
            if (tbTariff.Text != "")
            {
                if (StateSave)
                {

                }
                else
                {
                    CreateGV();
                }
            }
        }


        private void AddClient()
        {
            tbSurname.Text = SelectClient.ClientSelect.surname;
            tbName.Text = SelectClient.ClientSelect.name;
            tbMiddleName.Text = SelectClient.ClientSelect.middleName;
            ID_Client = SelectClient.ClientSelect.id;
            SelectClient.ClientSelect = new Client();

            string WayDir1 = Options.FindByID(1).Value + "/";
            if (Photo.FindByIDUser(ID_Client) != null)
            {
                string NamePhoto1 = Photo.FindByIDUser(ID_Client).Name;
                string a = WayDir1 + NamePhoto1;
                pictureBox1.Image = Image.FromFile(a);
            }
            getClient.Visible = true;
        }

        private void AddTariff()
        {
            tbTariff.Text = SelectTariff.TariffSelect.name;
            ID_Tariff = SelectTariff.TariffSelect.id;
            SelectTariff.TariffSelect = new Tariff();
        }

        private void CreateGV() //НОВАЯ КАРТА
        {
            GVServiceInTariff.Rows.Clear();

            List<ServiceInTariff> Services = ServiceInTariff.GetServices(ID_Tariff);

            for (int i = 0; i < Services.Count; i++)// создание таблицы с УСЛУГАМИ
            {
                Service service = Service.FindByID(Services[i].ID_Service);
                GVServiceInTariff.Rows.Add(service.id, service.name, Services[i].Amount, Services[i].Periodicity);
            }
        }

        private void CreateGV1() //КАРТА УЖЕ ЕСТЬ В БАЗЕ
        {
            GVServiceInTariff.Rows.Clear();

            List<BalanceCard> Services = BalanceCard.GetBalance(RadForm1.ID_Card);

            for (int i = 0; i < Services.Count; i++)// создание таблицы с УСЛУГАМИ
            {
                Service service = Service.FindByID(Services[i].ID_Service);
                GVServiceInTariff.Rows.Add(service.id, service.name, Services[i].Balance/*, Services[i].Periodicity*/);
            }
        }

        private void tbIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void AddServicesInBalanceCard(int ID_Tariff, int ID_Card)//добавляем услуги на карту(по тарифу) ДЛЯ НОВОЙ КАРТЫ!
        {
            Tariff tariff = Tariff.FindByID(ID_Tariff);
            List<ServiceInTariff> ServiceList = ServiceInTariff.GetServices(ID_Tariff);
            for (int i = 0; i < ServiceList.Count; i++)
            {
                BalanceCard.Add(ID_Card, ServiceList[i].ID_Service, ServiceList[i].Amount);
            }
        }

    }

}
