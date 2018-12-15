using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace CRM
{
    public partial class ClientCard : Telerik.WinControls.UI.RadForm
    {
        public ClientCard()
        {
            InitializeComponent();
        }

        public bool StateSave = false;//true - клиент уже существует, false - новый клиент
        List<Card> CardList = new List<Card>(); //карты клиента

        string NamePhoto = "";
        string WayDir = "";

        private void ClientCard_Load(object sender, EventArgs e)
        {
            dtDOB.MaxDate = DateTime.Today.AddYears(-5);
            dtDOB.MinDate = DateTime.Today.AddYears(-90);

            spHeight.Minimum = 80;
            spHeight.Maximum = 220;
            spWeight.Minimum = 30;
            spWeight.Maximum = 200;

            cbNCard.Items.Clear();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            СhangeLoginPassword();
            if (StateSave)
            {
                GetCard();
                VisibleInfoCard(true);
            }
            else
            {
                VisibleInfoCard(false);
            }
        }

        private void FillForm(Client client)
        {
            tbSurname.Text = client.surname;
            tbName.Text = client.name;
            tbMiddleName.Text = client.middleName;
            dtDOB.Value = client.dob;

            tbHealth.Text = client.health;
            if (client.height != 0 && client.weight != 0)
            {
                spHeight.Value = client.height;
                spWeight.Value = client.weight;

            }

            if (client.sex == 1)// 1 - men, 0 - women
            {
                sexM.IsChecked = true;
            }
            if (client.sex == 0)
            {
                sexW.IsChecked = true;
            }
            tbPhone.Text = client.phone;
            tbEmail.Text = client.email;
            tbComment.Text = client.comment;
            tbLogin.Text = client.login;
            tbPassword.Text = client.password;

            this.Text = "Клиент: " + client.surname + " " + client.name + " " + client.middleName;

            string WayDir1 = Options.FindByID(1).Value + "/";
            if (Photo.FindByIDUser(RadForm1.ID_Client) != null)
            {
                string NamePhoto1 = Photo.FindByIDUser(RadForm1.ID_Client).Name;
                string a = WayDir1 + NamePhoto1;
                pictureBox1.Image = Image.FromFile(a);
            }
            
        }

        private void PVClients_SelectedPageChanged(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void RefreshPage()
        {
            if (PVClients.SelectedPage == pvLogin)
            {
                СhangeLoginPassword();
            }

        }

        private void ClientCard_Shown(object sender, EventArgs e)
        {
            if (StateSave)
            {
                Client client = Client.FindByID(RadForm1.ID_Client);
                FillForm(client);
            }
        }

        private void SaveForm()
        {
            if (Validation())
            {
                bool sex = true;
                if (sexW.IsChecked)
                {
                    sex = false;
                }
                Client client = new Client();
                Photo photo = new Photo();

                if (StateSave)
                {
                    client.Save(RadForm1.ID_Client, tbSurname.Text, tbName.Text, tbMiddleName.Text,
                    sex, Convert.ToInt32(spHeight.Value), Convert.ToInt32(spWeight.Value),
                    tbPhone.Text, tbEmail.Text, dtDOB.Value, tbComment.Text, tbHealth.Text, tbLogin.Text,
                    tbPassword.Text);
                    if (NamePhoto != "" && WayDir != "")
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            var ph = db.Photos
                            .Where(x => x.ID_User == RadForm1.ID_Client && x.DateDelete == null).FirstOrDefault();
                            if (ph == null)
                            {
                                photo.AddPhotoUser(RadForm1.ID_Client, WayDir, NamePhoto);
                            }
                            else
                            {
                                photo.SavePhotoUser(ph.ID, WayDir, NamePhoto);
                            }
                        }
                    }
                        
                }
                else
                {
                    RadForm1.ID_Client = client.Add(tbSurname.Text, tbName.Text, tbMiddleName.Text,
                    sex, Convert.ToInt32(spHeight.Value), Convert.ToInt32(spWeight.Value),
                    tbPhone.Text, tbEmail.Text, dtDOB.Value, tbComment.Text, tbHealth.Text, tbLogin.Text,
                    tbPassword.Text);
                    if (WayDir != "" && NamePhoto != "")
                    {
                        photo.AddPhotoUser(RadForm1.ID_Client, WayDir, NamePhoto);
                    }
                }
                MessageBox.Show(
                "Изменения успешно сохранены",
                "Результат сохранения",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

                StateSave = true;

                //this.Close();
            }
        }

        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            if (tbSurname.Text == "") { error.SetError(tbSurname, "Заполните поле!"); message += "Фамилия \n"; v = false; }
            if (tbName.Text == "") { error.SetError(tbName, "Заполните поле!"); message += "Имя \n"; v = false; }
            if (tbMiddleName.Text == "") { error.SetError(tbMiddleName, "Заполните поле!"); message += "Отчество \n"; v = false; }
            if (tbPhone.Text == "") { error.SetError(tbPhone, "Заполните поле!"); message += "Телефон \n"; v = false; }
            if (sexM.IsChecked == false && sexW.IsChecked == false) {/* error.SetError(tbPhone, "Заполните поле!");*/ message += "Пол \n"; v = false; }

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

        ///////////Главная
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Удалить клиента?",
            "Удаление клиента " + tbSurname.Text + ' ' + tbName.Text + ' ' + tbMiddleName.Text,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                User.Del(RadForm1.ID_Client);
            }

        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "Text files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string a = openFileDialog1.FileName.Replace(@"\", @"\\");
                //MessageBox.Show(a);
                pictureBox1.Image = Image.FromFile(a);
                //char x = '\\';
                string[] way = a.Split(new char[] { '\\' });
                for (int i = 0; i < way.Length - 1; i++)
                {
                    WayDir = WayDir + way[i] + "\\";
                    i++;
                }
                int k = way.Length;
                NamePhoto = way[k - 1];
            }
        }

        ///////////ЛОГИН
        private void СhangeLoginPassword()
        {
            int n = cbLogin.Items.Count;
            int k = 0;

            if (tbEmail.Text != "")
            {
                for (int i = 0; i < n; i++) { if (cbLogin.Items[i].ToString() == "Почта") { k++; } }
                if (k == 0) { cbLogin.Items.Add("Почта"); }
                k = 0;
            }
            if (tbPhone.Text != "")
            {
                for (int i = 0; i < n; i++) { if (cbLogin.Items[i].ToString() == "Телефон") { k++; } }
                if (k == 0) { cbLogin.Items.Add("Телефон"); }
                k = 0;
            }
            for (int i = 0; i < n; i++) { if (cbLogin.Items[i].ToString() == "Новый") { k++; } }
            if (k == 0) { cbLogin.Items.Add("Новый"); }

            tbPassword.PasswordChar = '*';
            tbPassword2.PasswordChar = '*';

            if (StateSave)
            {
                tbLogin.Enabled = false;

                cbLogin.Visible = false;
                tbPassword2.Visible = false;
                tbPassword.Visible = false;
                lblPassword1.Visible = false;
                lblPassword2.Visible = false;
            }
            else
            {
                tbLogin.Enabled = true;

                cbLogin.Visible = true;
                tbPassword2.Visible = true;
                tbPassword.Visible = true;
                lblPassword2.Visible = true;
            }
            СhangeLogin();
        }

        private void СhangeLogin() // изменение комбобокса с логином
        {
            switch (cbLogin.Text)
            {
                case "Почта":
                    tbLogin.Text = tbEmail.Text;
                    tbLogin.Enabled = false;
                    break;
                case "Телефон":
                    tbLogin.Text = tbPhone.Text;
                    tbLogin.Enabled = false;
                    break;
                case "Новый":
                    tbLogin.Text = "";
                    tbLogin.Enabled = true;
                    break;
            }
        }

        private void cbLogin_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            СhangeLogin();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Visible = true;
            lblPassword1.Visible = true;
            tbPassword2.Visible = true;
            lblPassword2.Visible = true;
            tbPassword.Text = "";
            tbPassword2.Text = "";
        }

        private void btnSaveLoginPassword_Click(object sender, EventArgs e)
        {
            if (StateSave)
            {
                if (Validation())
                {
                    if (tbPassword.Text != tbPassword2.Text) { SavePassword(false); }
                    else { SavePassword(true); }
                }
            }
            else
            {
                if (Validation())
                {
                    if (tbPassword.Text != tbPassword2.Text) { SavePassword(false); }
                    else { SavePassword(true); }
                }
            }
        }

        private void SavePassword(bool n)//true - сохранить false - ошибка
        {
            if (n && ValidationLoginPassword())
            {
                SaveForm();
                tbPassword.Visible = false;
                tbPassword2.Visible = false;
                lblPassword1.Visible = false;
                lblPassword2.Visible = false;
                error.Clear();
                DialogResult result = MessageBox.Show(
                "Пароль успешно сохранен!",
                "Успешно!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                error.SetError(tbPassword2, "Пароли не совпадают!");
                tbPassword.Text = "";
                tbPassword2.Text = "";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbLogin.Enabled = true;
            cbLogin.Visible = true;
        }

        private bool ValidationLoginPassword() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            if (tbLogin.Text == "") { error.SetError(tbSurname, "Заполните поле!"); message += "Логин \n"; v = false; }
            if (tbPassword.Text == "") { error.SetError(tbName, "Заполните поле!"); message += "Пароль \n"; v = false; }

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

        ///////////КАРТЫ
        private void VisibleInfoCard(bool state) // истина - показать, ложь - скрыть
        {
            if (state)
            {
                lbNCard.Visible = true;
                lbDate1.Visible = true;
                lbDate2.Visible = true;
                lbService.Visible = true;
                lbTariff.Visible = true;

                cbNCard.Visible = true;
                tbTariff.Visible = true;
                dtDateOfCreation.Visible = true;
                dtTariffEnd.Visible = true;
                GVBalanceCard.Visible = true;

                showCard.Visible = true;
            }
            else
            {
                lbNCard.Visible = false;
                lbDate1.Visible = false;
                lbDate2.Visible = false;
                lbService.Visible = false;
                lbTariff.Visible = false;

                cbNCard.Visible = false;
                tbTariff.Visible = false;
                dtDateOfCreation.Visible = false;
                dtTariffEnd.Visible = false;
                GVBalanceCard.Visible = false;

                showCard.Visible = false;
            }
        }

        private void GetCard()
        {
            CardList = Card.GetCardByClient(RadForm1.ID_Client);
            int p = 0;
            for (int i = 0; i < CardList.Count; i++)
            {
                for (int x = 0; x < cbNCard.Items.Count; x++)
                {
                    if (cbNCard.Items[x].Text == CardList[i].n_Card)
                    {
                        p++;
                    }
                }
                if (p == 0)
                {
                    cbNCard.Items.Add(CardList[i].n_Card);
                }
                p = 0;
            }
            cbNCard.SelectedIndex = 0;
            if (CardList.Count != 0)
            {
                VisibleInfoCard(true);
            }
            else
            {
                VisibleInfoCard(false);
            }
        }

        private void cbNCard_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e) //выбор карты
        {
            int ID_Card = 0;
            for (int i = 0; i < CardList.Count; i++)
            {
                if (cbNCard.Text == CardList[i].n_Card)
                {
                    ID_Card = CardList[i].id;
                }
            }
            Card card = Card.FindByID(ID_Card);

            dtDateOfCreation.Value = Convert.ToDateTime(card.dateOfCreation);
            tbTariff.Text = Tariff.FindByID(card.id_Tariff).name;
            dtTariffEnd.Value = Convert.ToDateTime(card.dateOfCreation).AddDays(Tariff.FindByID(card.id_Tariff).duration);

            GVBalanceCard.Rows.Clear();

            List<BalanceCard> BalanceList = BalanceCard.GetBalance(ID_Card);
            for (int i = 0; i <= BalanceList.Count - 1; i++)// создание таблицы с Услугами
            {
                GVBalanceCard.Rows.Add(BalanceList[i].ID_Service, Service.FindByID(BalanceList[i].ID_Service).name, BalanceList[i].Balance);
            }

            //tbRestOfDays.Text = Convert.ToString((dtTariffEnd.Value - DateTime.Today).TotalDays);

        }

        private void addCard_Click(object sender, EventArgs e)
        {
            CardCard cardCard = new CardCard();
            cardCard.StateSave = false;
            CardCard.ID_Client = RadForm1.ID_Client;
            cardCard.ShowDialog();

            GetCard();
        }

        private void showCard_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CardList.Count; i++)
            {
                if (CardList[i].n_Card == cbNCard.Text)
                {
                    RadForm1.ID_Card = CardList[i].id;
                }
            }
            CardCard cardCard = new CardCard();
            cardCard.StateSave = true;
            cardCard.ShowDialog();

            GetCard();
        }

        ///////////Платежи
        private void addPay_Click(object sender, EventArgs e)
        {
            PayCard payCard = new PayCard();
            payCard.ShowDialog();
        }

        ///////////Физиология
        private void saveHealth_Click(object sender, EventArgs e)
        {
            SaveForm();
        }
    }
}
