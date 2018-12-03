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
    public partial class ClientCard : Telerik.WinControls.UI.RadForm
    {
        public ClientCard()
        {
            InitializeComponent();
        }

        public bool StateSave = false;//true - клиент уже существует, false - новый клиент

        private void ClientCard_Load(object sender, EventArgs e)
        {
            dtDOB.MaxDate = DateTime.Today.AddYears(-5);
            dtDOB.MinDate = DateTime.Today.AddYears(-90);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveForm();
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
                if (tbLogin.Text == "" && tbPassword.Text == "")
                {
                    tbLogin.Enabled = true;

                    cbLogin.Visible = true;
                    tbPassword2.Visible = true;
                    tbPassword.Visible = true;
                    lblPassword2.Visible = true;
                }
                else
                {
                    tbLogin.Enabled = false;

                    cbLogin.Visible = false;
                    tbPassword2.Visible = false;
                    tbPassword.Visible = false;
                    lblPassword1.Visible = false;
                    lblPassword2.Visible = false;
                }
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


            //if (tbLogin.Text == "")
            //{
            //    cbLogin.SelectedIndex = 0;
            //}
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

        private void PWClient_SelectedPageChanged(object sender, EventArgs e) //вкладки
        {
            if (PWClient.SelectedPage == pvLogin) // 2 вход в систему
            {
                СhangeLoginPassword();
            }

            if (PWClient.SelectedPage == pvHealth) // 4 Физиология
            {
                spHeight.Minimum = 80;
                spHeight.Maximum = 220;
                spWeight.Minimum = 30;
                spWeight.Minimum = 200;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Удалить клиента?",
            "Удаление клиента "+tbSurname.Text+' '+tbName.Text+' '+tbMiddleName.Text,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Client.Del(RadForm1.ID_Client);
            }
                
        }

        private void ClientCard_Shown(object sender, EventArgs e)
        {
            if (StateSave)
            {
                Client client = Client.FindClientByID(RadForm1.ID_Client);
                FillForm(client);
            }
            
           
        }

        private void FillForm(Client client)
        {
            tbSurname.Text = client.surname;
            tbName.Text = client.name;
            tbMiddleName.Text = client.middleName;
            dtDOB.Value = client.dob;
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

            StateSave = true;
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
                if (StateSave)
                {
                    client.Save(RadForm1.ID_Client, tbSurname.Text, tbName.Text, tbMiddleName.Text,
                    sex, Convert.ToInt32(spHeight.Value), Convert.ToInt32(spWeight.Value),
                    tbPhone.Text, tbEmail.Text, dtDOB.Value, tbComment.Text, tbHealth.Text, tbLogin.Text,
                    tbPassword.Text);
                }
                else
                {
                    client.Add(tbSurname.Text, tbName.Text, tbMiddleName.Text,
                    sex, Convert.ToInt32(spHeight.Value), Convert.ToInt32(spWeight.Value),
                    tbPhone.Text, tbEmail.Text, dtDOB.Value, tbComment.Text, tbHealth.Text, tbLogin.Text,
                    tbPassword.Text);
                    StateSave = true;
                }
                MessageBox.Show(
                "Изменения успешно сохранены",
                "Результат сохранения",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbLogin.Enabled = true;
            cbLogin.Visible = true;
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
    }
}
