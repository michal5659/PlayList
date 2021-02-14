using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public static class StatisticsOnStudentConverter
    {
        public static StatisticsOnStudent ConvertStatisticsToDAL(StatisticsOnStudentDTO statistics)
        {
            return new StatisticsOnStudent
            {
                GameForStudentCode = statistics.GameForStudentCode,
                WeekCode = statistics.WeekCode,
                StudentCode = statistics.StudentCode,
                GameCode = statistics.GameCode,
                Errors = statistics.Errors,
                ErrorsForWord = statistics.ErrorsForWord,
                NumOfSuccesses = statistics.NumOfSuccesses,
                NumOfCorrections = statistics.NumOfCorrections,
                WordErrors = statistics.WordErrors.Select(w => new WordError { NumErrors = w.NumErrors, StatistictToStudentsId = w.StatistictToStudentsId, WordId = w.WordId }).ToList()

            };
        }

        public static StatisticsOnStudentDTO ConvertStatisticsToDTO(StatisticsOnStudent statistics)
        {
            return new StatisticsOnStudentDTO
            {
                GameForStudentCode = statistics.GameForStudentCode,
                WeekCode = statistics.WeekCode,
                StudentCode = statistics.StudentCode,
                GameCode = statistics.GameCode,
                Errors = statistics.Errors,
                ErrorsForWord = statistics.ErrorsForWord,
                NumOfSuccesses = statistics.NumOfSuccesses,
                NumOfCorrections = statistics.NumOfCorrections,
                WordErrors = statistics.WordErrors.Select(w => new WordErrorDto { NumErrors = w.NumErrors, StatistictToStudentsId = w.StatistictToStudentsId, WordId = w.WordId }).ToList()
            };
        }

        public static List<StatisticsOnStudentDTO> ConvertStatisticsListToDTO(List<StatisticsOnStudent> statistics)
        {
            return statistics.Select(s => ConvertStatisticsToDTO(s)).ToList();
        }
    }
}
