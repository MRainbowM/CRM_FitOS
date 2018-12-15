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
    public partial class ServiceCard : Telerik.WinControls.UI.RadForm
    {
        public ServiceCard()
        {
            InitializeComponent();
        }

        public bool StateSave = false;

        private void ServiceCard_Load(object sender, EventArgs e)
        {
            spCost.DecimalPlaces = 2;
            spCost.Maximum = 100000;

            spPeople.Maximum = 100;
            spPeople.Minimum = 1;

            if (StateSave)
            {
                Service service = Service.FindByID(RadForm1.ID_Service);
                FillForm(service);
            }
            else
            {
                delTrainer.Visible = false;
                delRoom.Visible = false;
            }
        }

        private void FillForm(Service service)
        {
            tbName.Text = service.name;
            tbComment.Text = service.comment;
            spCost.Value = Convert.ToDecimal(service.cost);
            spPeople.Value = service.numberOfPeople;
            spMinuts.Value = service.duration;
            CreateGVRooms();
            CreateGVTariners();
        }

        ///Главная
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveForm();
        }

        private void SaveForm()
        {
            if (Validation())
            {
                Service service = new Service();
                if (StateSave)
                {
                    service.Save(RadForm1.ID_Service, tbName.Text, Convert.ToInt32(spCost.Value), Convert.ToInt32(spPeople.Value), tbComment.Text, Convert.ToInt32(spMinuts.Value));
                }
                else
                {
                    RadForm1.ID_Client = service.Add(tbName.Text, spCost.Value, Convert.ToInt32(spPeople.Value), tbComment.Text, Convert.ToInt32(spMinuts.Value));
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
                //this.Close();
            }

        }

        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            if (tbName.Text == "") { error.SetError(tbName, "Заполните поле!"); message += "Название услуги \n"; v = false; }
            if (spCost.Value == 0) { error.SetError(spCost, "Заполните поле!"); message += "Цена \n"; v = false; }
            if (spPeople.Value == 0) { error.SetError(spPeople, "Заполните поле!"); message += "Вместимость услуги \n"; v = false; }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Удалить клиента?",
           "Удаление клиента " + tbName.Text,
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Exclamation,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Service.Del(RadForm1.ID_Service);
            }
        }

        ///Тренера
        private void addWorker_Click(object sender, EventArgs e)
        {
            SelectTrainer selectWorker = new SelectTrainer();
            selectWorker.Show();
        }

        private void del_Click(object sender, EventArgs e)
        {
            SelectTrainer selectWorker = new SelectTrainer();
            selectWorker.Show();
        }


        private void CreateGVTariners()
        {
            List<TrainerService> TrainersList = TrainerService.GetTrainers(RadForm1.ID_Service);
            GVTariners.Rows.Clear();
            string fio;
            for (int i = 0; i < TrainersList.Count; i++)
            {
                fio = Trainer.FindByID(TrainersList[i].ID_Trainer).surname + " " + Trainer.FindByID(TrainersList[i].ID_Trainer).name + " " + Trainer.FindByID(TrainersList[i].ID_Trainer).middleName;
                GVTariners.Rows.Add(TrainersList[i].ID_Trainer, fio);
                //SelectService.ServiceInGV.Add(Service.FindByID(ServiceList[i].ID_Service));
            }
            if (GVTariners.RowCount == 0)
            {
                delTrainer.Visible = false;
            }
            else
            {
                delTrainer.Visible = true;
            }

        }

        ///Помещения
        private void CreateGVRooms()
        {
            List<ServiceInRoom> RoomsList = ServiceInRoom.GetRooms(RadForm1.ID_Service);
            GVRooms.Rows.Clear();

            for (int i = 0; i <= RoomsList.Count - 1; i++)
            {
                GVRooms.Rows.Add(RoomsList[i].ID_Room, Room.FindByID(RoomsList[i].ID_Room).name, Room.FindByID(RoomsList[i].ID_Room).equipment, Room.FindByID(RoomsList[i].ID_Room).capacity);
                SelectRoom.RoomsInGV.Add(Room.FindByID(RoomsList[i].ID_Room));
            }
            if (GVRooms.RowCount == 0)
            {
                delRoom.Visible = false;
            }
            else
            {
                delRoom.Visible = true;
            }
        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            SelectRoom SelectRoom = new SelectRoom();
            SelectRoom.ShowDialog();
            AddRoomInGV();
        }

        private void AddRoomInGV()
        {
            int p = 0;
            if (GVRooms.RowCount != 0)
            {
                for (int i = 0; i < SelectRoom.RoomsList.Count; i++)
                {
                    for (int x = 0; x < GVRooms.RowCount; x++)
                    {
                        if (Convert.ToInt32(GVRooms.Rows[x].Cells[0].Value) == SelectRoom.RoomsList[i].id)
                        {
                            p++;
                        }
                    }
                    if (p == 0)
                    {
                        GVRooms.Rows.Add(SelectRoom.RoomsList[i].id, SelectRoom.RoomsList[i].name, SelectRoom.RoomsList[i].equipment, SelectRoom.RoomsList[i].capacity);
                        SelectRoom.RoomsInGV.Add(Room.FindByID(SelectRoom.RoomsList[i].id));
                    }
                    p = 0;
                }
            }
            else
            {
                for (int x = 0; x < SelectRoom.RoomsList.Count; x++)
                {
                    GVRooms.Rows.Add(SelectRoom.RoomsList[x].id, SelectRoom.RoomsList[x].name, SelectRoom.RoomsList[x].equipment, SelectRoom.RoomsList[x].capacity);
                    SelectRoom.RoomsInGV.Add(Room.FindByID(SelectRoom.RoomsList[x].id));
                }
            }
            if (GVRooms.RowCount != 0)
            {
                delRoom.Visible = true;
            }
            else
            {
                delRoom.Visible = false;
            }
        }

        private void saveRoom_Click(object sender, EventArgs e)
        {
            SaveRooms();
        }

        private void SaveRooms()
        {
            if (Validation())
            {
                SaveForm();
                using (ApplicationContext db = new ApplicationContext())
                {
                    int ID_Room;
                    for (int i = 0; i < GVRooms.RowCount; i++)
                    {
                        ID_Room = Convert.ToInt32(GVRooms.Rows[i].Cells[0].Value);

                        var service = ServiceInRoom.FindByIDServiceAndIDRoom(ID_Room, RadForm1.ID_Service);
                        if (service == null)
                        {
                            ServiceInRoom.Add(ID_Room, RadForm1.ID_Service);
                        }
                    }
                }
            }
        }

        private void delRoom_Click(object sender, EventArgs e)
        {
            int row = GVRooms.CurrentCell.RowIndex;
            int d = Convert.ToInt32(GVRooms.Rows[row].Cells[0].Value);

            DialogResult result = MessageBox.Show(
            "Удалить помещение " + (String)GVRooms.Rows[row].Cells[1].Value + "?",
            "Удаление помещения",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                DeleteRoom(d);
            }
        }

        private void DeleteRoom(int ID_Room)
        {
            List<Room> RoomList = new List<Room>();
            for (int i = 0; i < GVRooms.RowCount; i++)
            {
                if (Convert.ToInt32(GVRooms.Rows[i].Cells[0].Value) != ID_Room)
                {
                    RoomList.Add(Room.FindByID(Convert.ToInt32(GVRooms.Rows[i].Cells[0].Value)));
                }
            }
            GVRooms.Rows.Clear();
            for (int i = 0; i < RoomList.Count; i++)
            {
                GVRooms.Rows.Add(RoomList[i].id, RoomList[i].name, RoomList[i].equipment, RoomList[i].capacity);
            }
            if (GVRooms.RowCount == 0)
            {
                delRoom.Visible = false;
            }
            using (ApplicationContext db = new ApplicationContext())
            {
                var room = ServiceInRoom.FindByIDServiceAndIDRoom(ID_Room, RadForm1.ID_Service);
                if (room != null)
                {
                    ServiceInRoom.Del(ID_Room, RadForm1.ID_Service);
                }
            }
        }

        
    }
}
