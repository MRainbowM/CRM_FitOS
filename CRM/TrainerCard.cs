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
    public partial class TrainerCard : Telerik.WinControls.UI.RadForm
    {
        public TrainerCard()
        {
            InitializeComponent();
        }

        public bool StateSave = false;//true - тренер уже существует, false - новый тренер

        string NamePhoto = "";
        string WayDir = "";

        private void TrainerCard_Load(object sender, EventArgs e)
        {
            dtDOB.MaxDate = DateTime.Today.AddYears(-5);
            dtDOB.MinDate = DateTime.Today.AddYears(-90);
            SelectService.ServiceInGV.Clear();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (StateSave)
            {
                CreateGV();
                Trainer trainer = Trainer.FindByID(RadForm1.ID_Trainer);
                FillForm(trainer);
            }
        }

        private void FillForm(Trainer trainer)
        {
            tbSurname.Text = trainer.surname;
            tbName.Text = trainer.name;
            tbMiddleName.Text = trainer.middleName;
            dtDOB.Value = trainer.dob;
            tbQualification.Text = trainer.qualification;
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

            string WayDir1 = Options.FindByID(1).Value + "/";
            if (Photo.FindByIDUser(RadForm1.ID_Client) != null)
            {
                string NamePhoto1 = Photo.FindByIDUser(RadForm1.ID_Client).Name;
                string a = WayDir1 + NamePhoto1;
                pictureBox1.Image = Image.FromFile(a);
            }
        }

        private void SaveForm()
        {
            bool sex = true;
            if (sexW.IsChecked)
            {
                sex = false;
            }
            Trainer trainer = new Trainer();
            Photo photo = new Photo();
            if (StateSave)
            {
                trainer.Save(RadForm1.ID_Trainer, tbSurname.Text, tbName.Text, tbMiddleName.Text,
                sex, tbPhone.Text, tbQualification.Text, tbEmail.Text, dtDOB.Value, tbComment.Text, tbLogin.Text,
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
                RadForm1.ID_Trainer = trainer.Add(tbSurname.Text, tbName.Text, tbMiddleName.Text,
                sex, tbPhone.Text, tbQualification.Text, tbEmail.Text, dtDOB.Value, tbComment.Text, tbLogin.Text,
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

        ///////Главная
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SaveForm();
            }
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
                User.Del(RadForm1.ID_Trainer);
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

        ///////Услуги
        private void addService_Click(object sender, EventArgs e)//Добавить услуги 
        {
            SelectService selectService = new SelectService();
            selectService.ShowDialog();
            RefreshPage();
        }

        private void delService_Click(object sender, EventArgs e)//Удалить услугу 
        {
            int row = GVService.CurrentCell.RowIndex;
            string d = (String)GVService.Rows[row].Cells[0].Value;

            DialogResult result = MessageBox.Show(
            "Удалить услугу?" + (String)GVService.Rows[row].Cells[1].Value,
            "Удаление услуги",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                DeleteService(Int32.Parse(d));
                TrainerService.Del(Int32.Parse(d), RadForm1.ID_Trainer);
            }
        }

        private void DeleteService(int ID_Service) 
        {
            List<Service> ServiceList = new List<Service>();
            for (int i = 0; i < GVService.RowCount; i++)
            {
                if (Convert.ToInt32(GVService.Rows[i].Cells[0].Value) != ID_Service)
                {
                    ServiceList.Add(Service.FindByID(Convert.ToInt32((string)GVService.Rows[i].Cells[0].Value)));
                }
            }
            GVService.Rows.Clear();
            for (int i = 0; i < ServiceList.Count; i++)
            {
                GVService.Rows.Add(ServiceList[i].id, ServiceList[i].name);
            }
            if (GVService.RowCount == 0)
            {
                delService.Visible = false;
            }
        }

        private void AddServiceInGV()
        {
            int p = 0;
            if (GVService.RowCount != 0)
            {
                for (int i = 0; i < SelectService.ServiceList.Count; i++)
                {
                    for (int x = 0; x < GVService.RowCount; x++)
                    {
                        if (Convert.ToInt32((string)GVService.Rows[x].Cells[0].Value) == SelectService.ServiceList[i].id)
                        {
                            p++;
                        }
                    }
                    if (p == 0)
                    {
                        GVService.Rows.Add(SelectService.ServiceList[i].id, SelectService.ServiceList[i].name);
                        SelectService.ServiceInGV.Add(Service.FindByID(SelectService.ServiceList[i].id));
                    }
                    p = 0;
                }
            }

            else
            {
                for (int x = 0; x < SelectService.ServiceList.Count; x++)
                {
                    GVService.Rows.Add(SelectService.ServiceList[x].id, SelectService.ServiceList[x].name);
                    SelectService.ServiceInGV.Add(Service.FindByID(SelectService.ServiceList[x].id));
                }
            }
        }

        private void btnSaveServices_Click(object sender, EventArgs e)
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
                    for (int i = 0; i < GVService.RowCount; i++)
                    {
                        ID_Service = Convert.ToInt32((string)GVService.Rows[i].Cells[0].Value);

                        var service = db.TrainerServices
                        .Where(x => x.ID_Trainer == RadForm1.ID_Trainer && x.ID_Service == ID_Service).FirstOrDefault();
                        if (service == null)
                        {
                            TrainerService.Add(RadForm1.ID_Trainer, ID_Service);
                        }
                    }
                }
            }
        }

        private void CreateGV()
        {
            List<TrainerService> ServiceList = TrainerService.GetServices(RadForm1.ID_Trainer);
            GVService.Rows.Clear();

            for (int i = 0; i <= ServiceList.Count - 1; i++)
            {
                GVService.Rows.Add(ServiceList[i].ID_Service, Service.FindByID(ServiceList[i].ID_Service).name/*, ServiceList[i].Amount, ServiceList[i].Periodicity*/);
                SelectService.ServiceInGV.Add(Service.FindByID(ServiceList[i].ID_Service));
            }
        }

        ///////Логин
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

        private void cbLogin_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            СhangeLogin();
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
        



       
        private void RefreshPage()
        {
            if (PVTrainer.SelectedPage == pvLogin)
            {
                СhangeLoginPassword();
            }
            if (PVTrainer.SelectedPage == pvServices)
            {
                AddServiceInGV();

            }

        }

        private void PVTrainer_SelectedPageChanged(object sender, EventArgs e) // изменение вкладок
        {
            RefreshPage();
        }

       


    }
}
