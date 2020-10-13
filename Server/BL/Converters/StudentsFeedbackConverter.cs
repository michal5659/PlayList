using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public static class StudentsFeedbackConverter
    {
        public static StudentsFeedback ConvertStudentsFeedToDAL(StudentsFeedbackDTO studentsFeedback)
        {
            return new StudentsFeedback
            {
                FeedbackCode = studentsFeedback.FeedbackCode,
                StudentCode = studentsFeedback.StudentCode,
                WordCode = studentsFeedback.WordCode,
                Score = studentsFeedback.Score
            };
        }

        public static StudentsFeedbackDTO ConvertStudentsFeedToDTO(StudentsFeedback studentsFeedback)
        {
            return new StudentsFeedbackDTO
            {
                FeedbackCode = studentsFeedback.FeedbackCode,
                StudentCode = studentsFeedback.StudentCode,
                WordCode = studentsFeedback.WordCode,
                Score = studentsFeedback.Score
            };
        }

        public static List<StudentsFeedbackDTO> ConvertStudentsFeedListToDTO(List<StudentsFeedback> Feedbacks)
        {
            return Feedbacks.Select(sf => ConvertStudentsFeedToDTO(sf)).ToList();
        }
    }
}
