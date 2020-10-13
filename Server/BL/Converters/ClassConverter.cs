using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public static class ClassConverter
    {
        public static Class ConvertClassToDAL(ClassDTO classes)
        {
            return new Class
            {
                ClassCode = classes.ClassCode,
                ClassName = classes.ClassName,
                LayerNumber = classes.LayerNumber,
                SchoolCode = classes.SchoolCode
            };
        }

        public static ClassDTO ConvertClassToDTO(Class classes)
        {
            return new ClassDTO
            {
                ClassCode = classes.ClassCode,
                ClassName = classes.ClassName,
                LayerNumber = classes.LayerNumber,
                SchoolCode = classes.SchoolCode
            };
        }

        public static List<ClassDTO> ConvertWorkerListToDTO(List<Class> classList)
        {
            return classList.Select(c => ConvertClassToDTO(c)).ToList();
        }
    }
}
