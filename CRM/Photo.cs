using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Photo
    {
        public int ID { get; set; }
        public int ID_User { get; set; }
        public int ID_Room { get; set; }
        public string Name { get; set; }
        public string DateDelete { get; set; }

        public void AddPhotoUser(int ID_User, string WayDir, string NamePhoto)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //string x = Options.FindByID(1).Value;
                string x = WayDir;

                string h = "";
                string[] way = x.Split(new char[] { '\\' });

                for (int i = 0; i < way.Length; i++)
                {
                    h = h + way[i] + "/";
                    //i++;
                }
                //int k = way.Length;
                //NamePhoto = way[k - 1];
                //File.Copy(Path.Combine(WayDir, NamePhoto), Path.Combine(h, NamePhoto), true);

                File.Copy(Path.Combine(h, NamePhoto), Path.Combine(Options.FindByID(1).Value, NamePhoto), true);

                db.Database.EnsureCreated();
                Photo Photo = new Photo
                {
                    Name = NamePhoto,
                    ID_User = ID_User
                };
                db.Photos.Add(Photo);
                db.SaveChanges();
            }
        }

        public void SavePhotoUser(int ID_Photo, string WayDir, string NamePhoto)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string x = WayDir;

                string h = "";
                string[] way = x.Split(new char[] { '\\' });

                for (int i = 0; i < way.Length; i++)
                {
                    h = h + way[i] + "/";
                    //i++;
                }
                //int k = way.Length;
                //NamePhoto = way[k - 1];
                //File.Copy(Path.Combine(WayDir, NamePhoto), Path.Combine(h, NamePhoto), true);

                File.Copy(Path.Combine(h, NamePhoto), Path.Combine(Options.FindByID(1).Value, NamePhoto), true);
                db.Database.EnsureCreated();
                Photo Photo = db.Photos.Where(c => c.ID == ID_Photo).FirstOrDefault();
                Photo.Name = NamePhoto;
                db.SaveChanges();
                //File.Copy(Path.Combine(WayDir, NamePhoto), Path.Combine(Options.FindByID(1).Value, NamePhoto), true);
            }
        }


        public static Photo FindByID(int ID_Photo)
        {
            ApplicationContext db = new ApplicationContext();
            Photo Photo = db.Photos.Where(x => x.ID == ID_Photo).FirstOrDefault();
            return Photo;
        }

        public static Photo FindByIDUser(int ID_User)
        {
            ApplicationContext db = new ApplicationContext();
            Photo Photo = db.Photos.Where(x => x.ID_User == ID_User).FirstOrDefault();
            return Photo;
        }

    }
}
