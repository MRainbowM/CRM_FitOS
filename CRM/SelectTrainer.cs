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
    public partial class SelectTrainer : Telerik.WinControls.UI.RadForm
    {
        public SelectTrainer()
        {
            InitializeComponent();
        }

        public static List<Trainer> TrainersInGV = new List<Trainer>(); //тренера, которые уже есть в таблице

        public static List<Trainer> TrainerList = new List<Trainer>(); //лист для добавления тренеров

        public bool ForSchedule = false; //истина - если тренера выбираются для расписания

        private void SelectTrainer_Load(object sender, EventArgs e)
        {
            if (ForSchedule)
            {
                CreateGVTrainerForSchedule();
            }
            else
            {
                CreateGVAllTrainers();
            }
            

        }
        private void CreateGVAllTrainers()
        {
            GVTrainers.Rows.Clear();
            int p = 0;
            List<Trainer> Trainers = Trainer.GetAll();
            for (int i = 0; i <Trainers.Count; i++)// создание таблицы с Тренерами
            {
                for (int x = 0; x < TrainersInGV.Count; x++)
                {
                    if (Trainers[i].id == TrainersInGV[x].id)
                    {
                        p++;
                    }
                }
                if (p == 0)
                {
                    GVTrainers.Rows.Add(Trainers[i].id, Trainers[i].surname, Trainers[i].name, Trainers[i].middleName);
                }
                p = 0;
            }
        }

        private void CreateGVTrainerForSchedule()
        {
            GVTrainers.Rows.Clear();
            List<TrainerService> Trainers = TrainerService.GetTrainers(ScheduleCard.ID_Service);
            for (int i = 0; i < Trainers.Count; i++)// создание таблицы с Тренерами
            {
                GVTrainers.Rows.Add(Trainers[i].ID_Trainer, Trainer.FindByID(Trainers[i].ID_Trainer).surname, Trainer.FindByID(Trainers[i].ID_Trainer).name, Trainer.FindByID(Trainers[i].ID_Trainer).middleName);
            }
        }





        private void search_Click(object sender, EventArgs e)
        {
            SearchWorker searchWorker = new SearchWorker();
            searchWorker.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            TrainerList.Clear();
            Trainer trainer = new Trainer();
            for (int i = 0; i < GVTrainers.RowCount; i++)
            {
                if (GVTrainers.Rows[i].Cells[4].Value != null)
                {
                    trainer = Trainer.FindByID(Convert.ToInt32((string)GVTrainers.Rows[i].Cells[0].Value));
                    TrainerList.Add(trainer);
                }
            }
            this.Close();
        }

        
    }
}
