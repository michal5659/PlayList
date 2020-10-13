using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public static class SchoolConverter
    {
        public static School ConvertSchoolToDAL(SchoolDTO school)
        {
            return new School
            {
                SchoolCode = school.SchoolCode,
                SchoolName = school.SchoolName
            };
        }

        public static SchoolDTO ConvertSchoolToDTO(School school)
        {
            return new SchoolDTO
            {
                SchoolCode = school.SchoolCode,
                SchoolName = school.SchoolName
            };
        }

        public static List<SchoolDTO> ConvertSchoolListToDTO(List<School> schools)
        {
            return schools.Select(s => ConvertSchoolToDTO(s)).ToList();
        }
    }
}
