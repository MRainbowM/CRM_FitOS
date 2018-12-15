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
    public partial class ReiterationSchedule : Telerik.WinControls.UI.RadForm
    {
        public ReiterationSchedule()
        {
            InitializeComponent();
        }

        public bool StateEnd; //ложь - дата, истина - кол-во повторений
        List<string> DayList = new List<string>();
        DateTime Date1;
        int DurationService;
        List<DateTime> NewScheduleDateTime = new List<DateTime>();


        private void ReiterationSchedule_Load(object sender, EventArgs e)
        {
            spCount1.Minimum = 0;
            cbPeriod.Items.Add("Час");
            cbPeriod.Items.Add("День");
            //cbPeriod.Items.Add("Месяц");
            //cbPeriod.Items.Add("Год");
            cbPeriod.SelectedIndex = 0;
            dtDate.Value = ScheduleCard.Date;
            tTime.Value = ScheduleCard.Date;
            tbService.Text = Service.FindByID(ScheduleCard.ID_Service).name;

            dtEndDate.MinDate = ScheduleCard.Date;

            tbDuration.Text = ScheduleService.FindByID(RadForm1.ID_Schedule).Duration.ToString();
            DurationService = ScheduleService.FindByID(RadForm1.ID_Schedule).Duration;
            tbRoom.Text = Room.FindByID(ScheduleService.FindByID(RadForm1.ID_Schedule).ID_Room).name;

            Date1 = ScheduleCard.Date;

            string Day = ScheduleCard.Date.ToString("dddd");

            clDay.Items.Add("понедельник");
            clDay.Items.Add("вторник");
            clDay.Items.Add("среда");
            clDay.Items.Add("четверг");
            clDay.Items.Add("пятница");
            clDay.Items.Add("суббота");
            clDay.Items.Add("воскресенье");


            for (int i = 0; i < clDay.Items.Count; i++)
            {
                if (Convert.ToString(clDay.Items[i]) == Day)
                {
                    clDay.SetItemChecked(i, true);
                }
            }

            spEndCount.Enabled = false;
            dtEndDate.Enabled = false;
        }


        private void btnCreate_Click(object sender, EventArgs e) //СОЗДАТЬ
        {

        }

        private void rbDate_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rbDate.IsChecked)
            {
                dtEndDate.Enabled = true;
            }
            else
            {
                dtEndDate.Enabled = false;
            }
        }

        private void rbCount_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rbCount.IsChecked)
            {
                spEndCount.Enabled = true;
            }
            else
            {
                spEndCount.Enabled = false;
                
            }
        }

        private void clDay_SelectedItemChanged(object sender, EventArgs e)
        {

            //DayList.Clear();
            //for (int i = 0; i < 6; i++)
            //{
            //    var s = clDay.Items[i].CheckState;
            //    if (clDay.Items.CheckAllItems)
            //    {

            //    }
            //    clDay.Items[i].
            //}
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int Interval = Convert.ToInt32(spCount1.Value);
            List<string> WeekDays = new List<string>();
            for (int i = 0; i < clDay.Items.Count; i++) //выбранные дни недели
            {
                if (clDay.GetItemCheckState(i) == CheckState.Checked)
                {
                    WeekDays.Add(Convert.ToString(clDay.Items[i]));
                }
            }

            if (rbDate.IsChecked)
            {
                int Days = Convert.ToInt32((dtEndDate.Value - dtDate.Value).TotalDays); //разница между конечной датой и начальной
                DateTime OneDay = dtDate.Value;
                switch (cbPeriod.Text)
                {
                    case "Час":
                        int HoursInDay = Convert.ToInt32((Convert.ToDateTime(tTimeEnd.Value).Hour - Convert.ToDateTime(tTime.Value).Hour)); //количество часов
                        int numberOfClasses = HoursInDay / (DurationService / 60); //количество возможных занятий в день

                        //DateTime Time = Convert.ToDateTime(tTime.Value);

                        OneDay = OneDay.AddHours(-DurationService);/*.AddHours(Time.Hour).AddMinutes(Time.Minute);*/

                        for (int i = 1; i < Days + 2; i++)
                        {
                            for (int j = 0; j < WeekDays.Count; j++)
                            {
                                if (OneDay.ToString("dddd") == WeekDays[j])/* && (OneDay.Hour >= Convert.ToDateTime(tTime.Value).Hour || OneDay.Hour <= Convert.ToDateTime(tTimeEnd.Value).Hour*/
                                {
                                    for (int x = 0; x < numberOfClasses; x++)
                                    {
                                        OneDay = OneDay.AddMinutes(DurationService * Convert.ToInt32(spCount1.Value));
                                        NewScheduleDateTime.Add(OneDay);
                                    }
                                }
                            }
                            OneDay = dtDate.Value.AddDays(i);
                        }
                        
                        break;

                    case "День":
                        OneDay = OneDay.AddDays(1);
                        for (int i = 1; i < Days + 1; i++)
                        {
                            for (int j = 0; j < WeekDays.Count; j++)
                            {
                                if (OneDay.ToString("dddd") == WeekDays[j])
                                {
                                    NewScheduleDateTime.Add(OneDay);
                                }
                            }
                            OneDay = OneDay.AddDays(1);
                        }
                        break;


                    default:
                        break;

                }
                for (int i = 0; i < NewScheduleDateTime.Count; i++)
                {
                    GVSchedule.Rows.Add(NewScheduleDateTime[i].ToString("dddd"), NewScheduleDateTime[i]);
                }
            }




           










        }

        private void cbPeriod_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cbPeriod.Text == "Час")
            {
                lbEnd.Visible = true;
                tTimeEnd.Visible = true;
            }
            else
            {
                lbEnd.Visible = false;
                tTimeEnd.Visible = false;
            }
        }
    }
}
