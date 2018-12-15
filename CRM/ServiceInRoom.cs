using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    [Table("ServiceInRooms")]
    public class ServiceInRoom
    {
        public int ID_Service { get; set; }
        public int ID_Room { get; set; }

        public static void Add(int ID_Room, int ID_Service)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                ServiceInRoom ServiceInRoom = new ServiceInRoom
                {
                    ID_Service = ID_Service,
                    ID_Room = ID_Room
                };
                db.ServiceInRooms.Add(ServiceInRoom);
                db.SaveChanges();
            }
        }

        public static List<ServiceInRoom> GetServices(int ID_Room)
        {
            ApplicationContext db = new ApplicationContext();

            List<ServiceInRoom> ServiceInRoomList = db.ServiceInRooms
                    .Where(x => x.ID_Room == ID_Room)
                    .Select(x => new ServiceInRoom
                    {
                        ID_Service = x.ID_Service,
                        ID_Room = x.ID_Room
                    }
                    ).ToList();
            return ServiceInRoomList;
        }

        public static List<ServiceInRoom> GetRooms(int ID_Service)
        {
            ApplicationContext db = new ApplicationContext();

            List<ServiceInRoom> ServiceInRoomList = db.ServiceInRooms
                    .Where(x => x.ID_Service == ID_Service)
                    .Select(x => new ServiceInRoom
                    {
                        ID_Service = x.ID_Service,
                        ID_Room = x.ID_Room
                    }
                    ).ToList();
            return ServiceInRoomList;
        }

        public static void Del(int ID_Room, int ID_Service)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                ServiceInRoom ServiceInRoom = db.ServiceInRooms.Where(c => c.ID_Service == ID_Service && c.ID_Room == ID_Room).FirstOrDefault();

                db.ServiceInRooms.Remove(ServiceInRoom);
                db.SaveChanges();
            }
        }

        public static ServiceInRoom FindByIDServiceAndIDRoom(int ID_Room, int ID_Service)
        {
            ApplicationContext db = new ApplicationContext();
            ServiceInRoom ServiceInRoom = db.ServiceInRooms.Where(x => x.ID_Room == ID_Room && x.ID_Service == ID_Service).FirstOrDefault();
            return ServiceInRoom;
        }
    }
}
