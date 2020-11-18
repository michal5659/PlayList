using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SchoolBL
    {
        public static List<SchoolDTO> GetSchoolList()
        {
            using(PlayListEntities db=new PlayListEntities())
            {
                return Converters.SchoolConverter.ConvertSchoolListToDTO(db.Schools.ToList());
            }
        }
    }
}
