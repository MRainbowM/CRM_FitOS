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
    public partial class TrainerCard : Telerik.WinControls.UI.RadForm
    {
        public TrainerCard()
        {
            InitializeComponent();
        }

        public bool StateSave = false;//true - тренер уже существует, false - новый тренер

        private void TrainerCard_Load(object sender, EventArgs e)
        {
            dtDOB.MaxDate = DateTime.Today.AddYears(-5);
            dtDOB.MinDate = DateTime.Today.AddYears(-90);
        }

        private void addService_Click(object sender, EventArgs e)
        {
            SelectService selectService = new SelectService();
            selectService.Show();
        }

        private void delService_Click(object sender, EventArgs e)
        {
            SelectService selectService = new SelectService();
            selectService.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveForm();
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

        private void СhangeLogin()
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

        private void SaveForm()
        {
            if (Validation())
            {
                bool sex = true;
                if (sexW.IsChecked)
                {
                    sex = false;
                }
                Trainer trainer = new Trainer();
                if (StateSave)
                {
                    trainer.Save(RadForm1.ID_Trainer, tbSurname.Text, tbName.Text, tbMiddleName.Text,
                    sex, tbPhone.Text, tbQualification.Text,  tbEmail.Text, dtDOB.Value, tbComment.Text, tbLogin.Text,
                    tbPassword.Text);
                }
                else
                {
                    trainer.Add(tbSurname.Text, tbName.Text, tbMiddleName.Text,
                    sex, tbPhone.Text, tbQualification.Text, tbEmail.Text, dtDOB.Value, tbComment.Text, tbLogin.Text,
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

        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            if (tbSurname.Text == "") { error.SetError(tbSurname, "Заполните поле!"); message += "Фамилия \n"; v = false; }
            if (tbName.Text == "") { error.SetError(tbName, "Заполните поле!"); message += "Имя \n"; v = false; }
            if (tbMiddleName.Text == "") { error.SetError(tbMiddleName, "Заполните поле!"); message += "Отчество \n"; v = false; }
            if (tbPhone.Text == "") { error.SetError(tbPhone, "Заполните поле!"); message += "Телефон \n"; v = false; }
            if (sexM.IsChecked == false && sexW.IsChecked == false) { /*error.SetError(tbPhone, "Заполните поле!");*/ message += "Пол \n"; v = false; }

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

        private void FillForm(Trainer trainer)
        {
            tbSurname.Text = trainer.surname;
            tbName.Text = trainer.name;
            tbMiddleName.Text = trainer.middleName;
            dtDOB.Value = trainer.dob;
            if (trainer.sex == 1)// 1 - men, 0 - women
            {
                sexM.IsChecked = true;
            }
            if (trainer.sex == 0)
            {
                sexW.IsChecked = true;
            }
            tbPhone.Text = trainer.phone;
            tbEmail.Text = trainer.email;
            tbComment.Text = trainer.comment;
            tbLogin.Text = trainer.login;
            tbPassword.Text = trainer.password;

            StateSave = true;
        }

        private void TrainerCard_Shown(object sender, EventArgs e)
        {
            if (StateSave)
            {
                Trainer trainer = Trainer.FindClientByID(RadForm1.ID_Trainer);
                FillForm(trainer);
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

        private void PVTrainer_SelectedPageChanged(object sender, EventArgs e)
        {
            if (PVTrainer.SelectedPage == pvLogin)
            {
                СhangeLoginPassword();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbLogin.Enabled = true;
            cbLogin.Visible = true;
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

        private void btnPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Visible = true;
            lblPassword1.Visible = true;
            tbPassword2.Visible = true;
            lblPassword2.Visible = true;
            tbPassword.Text = "";
            tbPassword2.Text = "";
        }

        private void cbLogin_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            СhangeLogin();
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
