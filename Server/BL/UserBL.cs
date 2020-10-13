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
                db.Users.Add(user);
                db.SaveChanges();
                return user.UserCode;
            }
        }
    }
}
