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
            return new UserDTO
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

        public static List<UserDTO> ConvertUserListToDTO(List<User> users)
        {
            return users.Select(u => ConvertUserToDTO(u)).ToList();
        }
    }
}
