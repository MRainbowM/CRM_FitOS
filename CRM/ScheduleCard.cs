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

        private void addService_Click(object sender, EventArgs e)
        {
            SelectService selectService = new SelectService();
            selectService.Show();
        }

        private void sddTrainer_Click(object sender, EventArgs e)
        {
            SelectWorker selectWorker = new SelectWorker();
            selectWorker.Show();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            SelectClient selectClient = new SelectClient();
            selectClient.Show();
        }

        private void getRoom_Click(object sender, EventArgs e)
        {
            SelectRoom selectRoom = new SelectRoom();
            selectRoom.Show();
        }

        private void reiteration_Click(object sender, EventArgs e)
        {
            ReiterationSchedule reiterationSchedule = new ReiterationSchedule();
            reiterationSchedule.Show();
        }
    }
}
