using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public int UserCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int LayerNumber { get; set; }
        public int SchoolCode { get; set; }
    }
}
