using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public static class WeekConverter
    {
        public static Week ConvertWeekToDAL(WeekDTO week)
        {
            return new Week
            {
                WeekCode = week.WeekCode,
                Week1 = week.Week,
                ClassCode = week.ClassCode,
                CategoryCode = week.CategoryCode
            };
        }

        public static WeekDTO ConvertWeekToDTO(Week week)
        {
            return new WeekDTO
            {
                WeekCode = week.WeekCode,
                Week = week.Week1,
                ClassCode = week.ClassCode,
                CategoryCode = week.CategoryCode
            };
        }

        public static List<WeekDTO> ConvertWeekListToDTO(List<Week> weeks)
        {
            return weeks.Select(w => ConvertWeekToDTO(w)).ToList();
        }
    }
}
