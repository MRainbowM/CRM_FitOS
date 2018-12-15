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
    public partial class RoomCard : Telerik.WinControls.UI.RadForm
    {
        public RoomCard()
        {
            InitializeComponent();
        }

        public bool StateSave = false;

        private void RoomCard_Load(object sender, EventArgs e)
        {
            spCapacity.Minimum = 0;
            spCapacity.Maximum = 500;
            spCapacity.DecimalPlaces = 0;
            tbName.MaxLength = 200;
            if (StateSave)
            {
                Room room = Room.FindByID(RadForm1.ID_Room);
                FillForm(room);
            }
            else
            {
                btnDelete.Visible = false;
                delService.Visible = false;
                SelectService.ServiceInGV.Clear();
            }
        }

        private void FillForm(Room room)
        {
            tbName.Text = room.name;
            tbEquipment.Text = room.equipment;
            spCapacity.Value = room.capacity;
            tbComment.Text = room.comment;

            CreateGV();
           
        }

        private void CreateGV()
        {
            List<ServiceInRoom> ServiceList = ServiceInRoom.GetServices(RadForm1.ID_Room);
            GVService.Rows.Clear();

            for (int i = 0; i <= ServiceList.Count - 1; i++)
            {
                GVService.Rows.Add(ServiceList[i].ID_Service, Service.FindByID(ServiceList[i].ID_Service).name);
                SelectService.ServiceInGV.Add(Service.FindByID(ServiceList[i].ID_Service));
            }

            if (GVService.RowCount == 0)
            {
                delService.Visible = false;
            }
        }

        private void addService_Click(object sender, EventArgs e)
        {
            SelectService selectService = new SelectService();
            selectService.ShowDialog();
            RefreshPage();
        }

        private void delService_Click(object sender, EventArgs e)
        {
            int row = GVService.CurrentCell.RowIndex;
            string d = (String)GVService.Rows[row].Cells[0].Value;

            DialogResult result = MessageBox.Show(
            "Удалить услугу " + (String)GVService.Rows[row].Cells[1].Value + "?",
            "Удаление услуги" ,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                DeleteService(Int32.Parse(d));
            }
        }

        private void saveServices_Click(object sender, EventArgs e)
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

                        var service = ServiceInRoom.FindByIDServiceAndIDRoom(RadForm1.ID_Room, ID_Service);
                        if (service == null)
                        {
                            ServiceInRoom.Add(RadForm1.ID_Room, ID_Service);
                        }
                    }
                }
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
            using (ApplicationContext db = new ApplicationContext())
            {
                var service = ServiceInRoom.FindByIDServiceAndIDRoom(RadForm1.ID_Room, ID_Service);
                if (service != null)
                {
                    ServiceInRoom.Del(RadForm1.ID_Room, ID_Service);
                }
            }
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
            Room room = new Room();
            if (StateSave)
            {
                room.Save(RadForm1.ID_Room, tbName.Text, tbEquipment.Text, (int)spCapacity.Value, tbComment.Text);
            }
            else
            {
                RadForm1.ID_Room = room.Add(tbName.Text, tbEquipment.Text, (int)spCapacity.Value, tbComment.Text);
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
            if (tbName.Text == "") { error.SetError(tbName, "Добавьте название помещения!"); message += "Название помещения \n"; v = false; }
            if (spCapacity.Value == 0) { error.SetError(spCapacity, "Заполните поле!"); message += "Вместимость помещения \n"; v = false; }

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
            if (PVRooms.SelectedPage == pvServices)
            {
                AddServiceInGV();
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
            if (GVService.RowCount != 0)
            {
                delService.Visible = true;
            }
            else
            {
                delService.Visible = false;
            }
        }

       
    }
}
