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
        public static int RegisterTeacher(UserDTO teacher)
        {
            using(PlayListEntities db=new PlayListEntities())
            {
                User user = Converters.UserConverter.ConvertUserToDAL(teacher);
                user.Teacher = new Teacher();
                db.Users.Add(user);
                db.SaveChanges();
                return user.UserCode;
            }
        }

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

        public static void InviteStudent(UserDTO user)
        {
            EmailService.SendEmail(user.Email,"היי, שמחים על הרשמתכם ללמידת אנגלית חוויתית","<a href=''> </a>");
        }
    }

    
}
