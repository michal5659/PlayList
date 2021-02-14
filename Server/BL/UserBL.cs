using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserBL
    {
        //רישום מורה
        public static int RegisterTeacher(UserDTO teacher)
        {
            using (PlayListEntities db = new PlayListEntities())
            {
                User user = Converters.UserConverter.ConvertUserToDAL(teacher);
                user.Teacher = new Teacher();
                db.Users.Add(user);
                db.SaveChanges();
                return user.UserCode;
            }
        }

        //רישום תלמיד
        public static int RegisterStudent(UserDTO student)
        {
            using (PlayListEntities db = new PlayListEntities())
            {
                User user = Converters.UserConverter.ConvertUserToDAL(student);
                db.Users.Add(user);
                db.SaveChanges();
                InviteStudent(student);
                return user.UserCode;
            }
        }
        
        //מייל אישור רישום לתלמיד
        public static void InviteStudent(UserDTO user)
        {
            string url = "http://localhost:4200/registerConfirm/" + user.ID;
            EmailService.SendEmail(user.Email, "היי, שמחים על הרשמתכם ללמידת אנגלית חוויתית", "<a href='"+url+"'> </a>");
        }

        //בדיקה האם מורה
        public static bool? IsTeacher(string id, string password)
        {
            using (PlayListEntities db = new PlayListEntities())
            {
                return db.Users.FirstOrDefault(u => u.ID == id && u.Password == password)?.Teacher != null;
            }

        }

        //כניסה
        public static UserDTO Login(string userName, string password)
        {
            using (PlayListEntities db = new PlayListEntities())
            {
                try
                {
                    var u = db.Users.Where(l => l.ID == userName && l.Password == password).ToList();
                    return Converters.UserConverter.ConvertUserToDTO(u[0]);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(0);
                    return null;
                }
            }
        }
    }


}
