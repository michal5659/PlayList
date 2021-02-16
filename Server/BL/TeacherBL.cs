using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BL
{
    public class TeacherBL
    {

        public static List<ClassDTO> GetClassListForTeacher(int teacherId)
        {
            using (PlayListEntities db = new PlayListEntities())
            {
                var teacher = db.Teachers.Where(t => t.TeacherCode == teacherId).FirstOrDefault();
                var classes = teacher.User.Classes.ToList();
                var classList = Converters.ClassConverter.ConvertWorkerListToDTO(classes);


                //   classList.Insert(0, new ClassDTO { ClassCode = 0, ClassName = "כל הכיתות" });

                return classList;

            }
        }

        public static List<UserDTO> GetStudentListForTeacher(int teacherId, int classId)
        {

            using (PlayListEntities db = new PlayListEntities())
            {
                var teacher = db.Users.FirstOrDefault(u => u.UserCode == teacherId);
                var classes = teacher.Classes;
                if (classId != 0)
                    classes = classes.Where(c => c.ClassCode == classId).ToList();
                return Converters.UserConverter.ConvertUserListToDTO(
                   classes.SelectMany(c => c.Users.Where(u => u.UserCode != teacherId)).ToList()
                    );

            }
        }


        public static List<WeekDTO> GetWeekListForClass(int classId)
        {

            using (PlayListEntities db = new PlayListEntities())
            {
                return Converters.WeekConverter.ConvertWeekListToDTO(
                    db.Classes.FirstOrDefault(c => c.ClassCode == classId).Weeks.ToList()
                    );

            }
        }


        public static List<WordCategoryDTO> GetCategoryListForClass(int classId)
        {

            using (PlayListEntities db = new PlayListEntities())
            {
                var class1 = db.Classes.FirstOrDefault(c => c.ClassCode == classId);

                return Converters.WordCategoryConverter.ConvertWordCategoryListToDTO(
                    class1.Weeks.SelectMany(w => w.Words).
                    Select(c => c.WordCategory).Distinct().ToList());
            }
        }

    }
}