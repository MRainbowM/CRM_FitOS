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
    public partial class ScheduleCard : Telerik.WinControls.UI.RadForm
    {
        public ScheduleCard()
        {
            InitializeComponent();
        }

        public static int ID_Service;
        int ID_Room;

        public static int Count; //количество записей
        public static DateTime Date;

        public bool StateSave = false;
        List<Trainer> TrainerList = new List<Trainer>();

        private void ScheduleCard_Load(object sender, EventArgs e)
        {
            spPeople.Minimum = 1;
            spMinuts.Minimum = 1440;
            spCost.Maximum = 10000;
            dtDate.MinDate = DateTime.Now;

            if (StateSave)
            {
                FillForm();
                addService.Visible = false;
                addRoom.Visible = false;
                dtDate.Enabled = false;
                tTime.Enabled = false;
            }
            else
            {
                btnDelete.Visible = false;
                addClient.Visible = false;
            }
        }

        private void FillForm()
        {
            ScheduleService scheduleService = ScheduleService.FindByID(RadForm1.ID_Schedule);
            ID_Service = scheduleService.ID_Service;
            ID_Room = scheduleService.ID_Room;

            spCost.Value = Service.FindByID(ID_Service).cost;
            spMinuts.Minimum = Service.FindByID(ID_Service).duration;

            tbService.Text = Service.FindByID(ID_Service).name;
            tbRoom.Text = Room.FindByID(ID_Room).name;
            dtDate.Value = scheduleService.Date;
            tTime.Value = scheduleService.Date;
            spCost.Value = Service.FindByID(ID_Service).cost;
            spPeople.Value = scheduleService.NumberOfPeople;
            Date = scheduleService.Date;
            List<TrainerInSchedule> TrainerInScheduleList = TrainerInSchedule.FindByIDSchedule(RadForm1.ID_Schedule);
            for (int i = 0; i < TrainerInScheduleList.Count; i++)
            {
                lTrainer.Items.Add(Trainer.FindByID(TrainerInScheduleList[i].ID_Trainer).surname + " " + Trainer.FindByID(TrainerInScheduleList[i].ID_Trainer).name + " " + Trainer.FindByID(TrainerInScheduleList[i].ID_Trainer).middleName);
                TrainerList.Add(Trainer.FindByID(TrainerInScheduleList[i].ID_Trainer));
            }
        }

        private void tbService_TextChanged(object sender, EventArgs e)//изменяется услуга
        {
            tbMaxPeople.Text = Service.FindByID(ID_Service).numberOfPeople.ToString();
            spPeople.Maximum = Convert.ToInt32(tbMaxPeople.Text);
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
            ScheduleService scheduleService = new ScheduleService();
            if (StateSave)
            {
                scheduleService.Save(RadForm1.ID_Schedule, Convert.ToInt32(spPeople.Value), spCost.Value);
                List<TrainerInSchedule> TrainerBefor = TrainerInSchedule.FindByIDSchedule(RadForm1.ID_Schedule);
                for (int i = 0; i < TrainerBefor.Count; i++)
                {
                    TrainerInSchedule.Del(RadForm1.ID_Schedule, TrainerBefor[i].ID_Trainer);//удаляет тренера из расписания
                }
                for (int x = 0; x < TrainerList.Count; x++)
                {
                    TrainerInSchedule.Add(TrainerList[x].id, RadForm1.ID_Schedule);//добавляет тренера в расписание
                }
            }
            else
            {

                // AddHours(double value): добавляет к текущей дате несколько часов
                //AddMinutes(double value): добавляет к текущей дате несколько минут
                DateTime Time = Convert.ToDateTime(tTime.Value);
                DateTime Date = dtDate.Value.AddHours(Time.Hour).AddMinutes(Time.Minute);

                RadForm1.ID_Schedule = scheduleService.Add(ID_Service, ID_Room, Date, Convert.ToInt32(spPeople.Value), Convert.ToInt32(spMinuts.Value), spCost.Value);

                for (int i = 0; i < TrainerList.Count; i++)
                {
                    TrainerInSchedule.Add(TrainerList[i].id, RadForm1.ID_Schedule); //добавляет тренера в расписание
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
            btnDelete.Visible = true;
            addClient.Visible = true;
            error.Clear();
        }

        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;

            if (tbService.Text == "") { error.SetError(addService, "Добавьте услугу!"); message += "Услуга \n"; v = false; }
            if (tbRoom.Text == "") { error.SetError(addRoom, "Добавьте помещение!"); message += "Помещение \n"; v = false; }
            //if (lTrainer.Items.Count == 0) { error.SetError(addTrainer, "Добавьте тренера!"); message += "Тренер \n"; v = false; }
            //if (spCost.Value == 0) { error.SetError(spCost, "Заполните поле!"); message += "Цена \n"; v = false; }
            //if (spPeople.Value == 0) { error.SetError(spPeople, "Заполните поле!"); message += "Количество людей \n"; v = false; }

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
        

        private void addService_Click(object sender, EventArgs e)
        {
            SelectService selectService = new SelectService();
            selectService.ManyServices = false;
            selectService.ShowDialog();
            if (SelectService.SelectOneService != null && SelectService.SelectOneService.name != null)
            {
                ID_Service = SelectService.SelectOneService.id;
                tbService.Text = SelectService.SelectOneService.name;
            }
            spMinuts.Minimum = Service.FindByID(ID_Service).duration;
            spMinuts.Value = Service.FindByID(ID_Service).duration;
            spPeople.Value = Service.FindByID(ID_Service).numberOfPeople;
        }

        private void sddTrainer_Click(object sender, EventArgs e)
        {
            SelectTrainer selectTrainer = new SelectTrainer();
            //if (clTrainers.Items.Count != 0)
            //{
            //    for (int i = 0; i < clTrainers.Items.Count; i++)
            //    {
            //        SelectTrainer.TrainersInGV.Add(Trainer.FindByID())
            //    }

            //}
            selectTrainer.ForSchedule = true;
            selectTrainer.ShowDialog();
            TrainerList.Clear();

            for (int i = 0; i < SelectTrainer.TrainerList.Count; i++)
            {
                lTrainer.Items.Add(SelectTrainer.TrainerList[i].surname + " " + SelectTrainer.TrainerList[i].name + " " + SelectTrainer.TrainerList[i].middleName);
                TrainerList.Add(SelectTrainer.TrainerList[i]);
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            SelectClient selectClient = new SelectClient();
            selectClient.ShowDialog();
            if (SelectClient.ClientSelect != null)
            {
                GVClients.Rows.Add(SelectClient.ClientSelect.id, SelectClient.ClientSelect.surname + " " + SelectClient.ClientSelect.name + " " + SelectClient.ClientSelect.middleName);
            }
        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            SelectRoom selectRoom = new SelectRoom();
            selectRoom.ForSchedule = true;
            selectRoom.ShowDialog();
            if (SelectRoom.SelectOneRoom != null && SelectRoom.SelectOneRoom.name != null)
            {
                tbRoom.Text = SelectRoom.SelectOneRoom.name;
                ID_Room = SelectRoom.SelectOneRoom.id;
            }
        }

        private void reiteration_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SaveForm();
                ReiterationSchedule reiterationSchedule = new ReiterationSchedule();
                reiterationSchedule.ShowDialog();
                //this.Close();
            }

        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime Time = Convert.ToDateTime(tTime.Value);
            Date = dtDate.Value.AddHours(Time.Hour).AddMinutes(Time.Minute);
        }

        private void tTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime Time = Convert.ToDateTime(tTime.Value);
            Date = dtDate.Value.AddHours(Time.Hour).AddMinutes(Time.Minute);
            tTimeEnd.Value = Convert.ToDateTime(tTime.Value).AddMinutes(Convert.ToInt32(spMinuts.Value));
        }

        private void spMinuts_ValueChanged(object sender, EventArgs e)
        {
            tTimeEnd.Value = Convert.ToDateTime(tTime.Value).AddMinutes(Convert.ToInt32(spMinuts.Value));
        }

        





        //private void RefreshCard()
        //{
        //    if (SelectService.SelectOneService != null && SelectService.SelectOneService.name != null)
        //    {
        //        tbService.Text = SelectService.SelectOneService.name;
        //        ID_Service = SelectService.SelectOneService.id;
        //    }
        //    if (SelectRoom.SelectOneRoom != null && SelectRoom.SelectOneRoom.name != null)
        //    {
        //        tbRoom.Text = SelectRoom.SelectOneRoom.name;
        //        ID_Room = SelectRoom.SelectOneRoom.id;
        //    }
        //}


    }
}
