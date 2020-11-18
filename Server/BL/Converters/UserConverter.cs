using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public static class UserConverter
    {
        public static User ConvertUserToDAL(UserDTO user)
        {
            return new User
            {
                UserCode = user.UserCode,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ID = user.ID,
                Password = user.Password,
                Email = user.Email,
                LayerNumber = user.LayerNumber,
                SchoolCode = user.SchoolCode
            };
        }

        public static UserDTO ConvertUserToDTO(User user)
        {
            UserDTO u = new UserDTO();

            u.UserCode = user.UserCode;
            u.FirstName = user.FirstName;
            u.LastName = user.LastName;
            u.ID = user.ID;
            u.Password = user.Password;
            u.Email = user.Email;
            if (user.LayerNumber.HasValue)
              u.LayerNumber = user.LayerNumber.Value;
            u.IsTeacher = user.Teacher != null;
            u.SchoolCode = user.SchoolCode;
            return u;
            
        }

        public static List<UserDTO> ConvertUserListToDTO(List<User> users)
        {
            return users.Select(u => ConvertUserToDTO(u)).ToList();
        }
    }
}
