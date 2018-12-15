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
    public partial class SelectRoom : Telerik.WinControls.UI.RadForm
    {
        public SelectRoom()
        {
            InitializeComponent();
        }

        private void SelectRoom_Load(object sender, EventArgs e)
        {
            if (ForSchedule)
            {
                CreateGVRoomForSchedule();
                GVRooms.Columns[4].IsVisible = false;
            }
            else
            {
                CreateGV();
            }
        }

        public static List<Room> RoomsInGV = new List<Room>();
        public static List<Room> RoomsList = new List<Room>(); //лист для добавления 
        public static Room SelectOneRoom;
        //public bool ManyRoom = true;

        public bool ForSchedule = false; //истина - если  выбираются для расписания

        private void CreateGVRoomForSchedule()
        {
            GVRooms.Rows.Clear();
            List<ServiceInRoom> Rooms = ServiceInRoom.GetRooms(ScheduleCard.ID_Service);
            for (int i = 0; i < Rooms.Count; i++)// создание таблицы с rooms
            {
                GVRooms.Rows.Add(Rooms[i].ID_Room, Room.FindByID(Rooms[i].ID_Room).name, Room.FindByID(Rooms[i].ID_Room).equipment, Room.FindByID(Rooms[i].ID_Room).capacity);
            }
        }

        private void CreateGV()
        {
            GVRooms.Rows.Clear();
            List<Room> Rooms = Room.GetAll();
            //for (int i = 0; i <= Rooms.Count - 1; i++)// создание таблицы с Комнатами
            //{
            //    GVRooms.Rows.Add(Rooms[i].id, Rooms[i].name, Rooms[i].equipment, Rooms[i].capacity);
            //}

            int p = 0;

            for (int i = 0; i <= Rooms.Count - 1; i++)// создание таблицы с Комнатами
            {
                for (int x = 0; x < RoomsInGV.Count; x++)
                {
                    if (Rooms[i].id == RoomsInGV[x].id)
                    {
                        p++;
                    }
                }
                if (p == 0)
                {
                    GVRooms.Rows.Add(Rooms[i].id, Rooms[i].name, Rooms[i].equipment, Rooms[i].capacity);
                }
                p = 0;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (ForSchedule)
            {
                SelectOneRoom = new Room();
                int row = GVRooms.CurrentCell.RowIndex;
                int d = Convert.ToInt32(GVRooms.Rows[row].Cells[0].Value);
                SelectOneRoom = Room.FindByID(Convert.ToInt32(d));
            }
            else
            {
                RoomsList.Clear();
                Room room = new Room();
                for (int i = 0; i < GVRooms.RowCount; i++)
                {
                    if (GVRooms.Rows[i].Cells[3].Value != null)
                    {
                        room = Room.FindByID(Convert.ToInt32(GVRooms.Rows[i].Cells[0].Value));
                        RoomsList.Add(room);
                    }
                }
            }
            RoomsInGV.Clear();
            ForSchedule = false;
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchRoom searchRoom = new SearchRoom();
            searchRoom.Show();
        }

        
    }
}
