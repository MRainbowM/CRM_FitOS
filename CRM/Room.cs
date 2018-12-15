using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Room
    {
        private int ID;
        private string Name;
        private string Equipment;
        private int Capacity;
        private string Comment;
        private string DateDelete;

        public int id
        {
            get { return ID; }
            private set { ID = value; }
        }
        public string name
        {
            get { return Name; }
            private set { Name = value; }
        }
        public string equipment
        {
            get { return Equipment; }
            private set { Equipment = value; }
        }
        public int capacity
        {
            get { return Capacity; }
            private set { Capacity = value; }
        }
        public string comment
        {
            get { return Comment; }
            private set { Comment = value; }
        }
        public string dateDelete
        {
            get { return DateDelete; }
            private set { DateDelete = value; }
        }

        public int Add(string Name, string Equipment, int Capacity, string Comment)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Room Room = new Room
                {
                    Name = Name,
                    Equipment = Equipment,
                    Capacity = Capacity,
                    Comment = Comment
                };
                db.Rooms.Add(Room);
                db.SaveChanges();
                int ID_Room = Room.id;
                return ID_Room;
            }
        }

        public void Save(int ID_Room, string Name, string Equipment, int Capacity, string Comment)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Room room = db.Rooms.Find(ID_Room);
                room.name = Name;
                room.equipment = Equipment;
                room.capacity = Capacity;
                room.comment = Comment;

                db.SaveChanges();
            }
        }

        public static Room FindByID(int ID_Room)
        {
            ApplicationContext db = new ApplicationContext();
            //Room Room = db.Rooms.Where(x => x.ID == ID_Room).FirstOrDefault();
            Room Room = db.Rooms.Find(ID_Room);
            return Room;
        }

        public static List<Room> GetAll()
        {
            ApplicationContext db = new ApplicationContext();

            List<Room> RoomList = db.Rooms
                    .Where(x => x.DateDelete == null)
                    .Select(x => new Room
                    {
                        ID = x.ID,
                        Name = x.Name,
                        Equipment = x.Equipment,
                        Capacity = x.Capacity,
                        Comment = x.Comment
                    }).ToList();
            return RoomList;
        }

        public static void Del(int ID_Room)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                Room Room = db.Rooms.Where(c => c.ID == ID_Room).FirstOrDefault();
                Room.DateDelete = DateTime.Today.ToString();

                db.SaveChanges();
            }
        }



    }
}
