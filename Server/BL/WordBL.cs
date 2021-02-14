using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class WordBL
    {
        //קבלת מילים למשחק לפי תלמיד
        public static GameDataDTO GetStudentsWords(string userId,int gameCode)
        {

            using (PlayListEntities db = new PlayListEntities())
            {
                GameDataDTO data = new GameDataDTO();
                StatisticsOnStudent statistics = new StatisticsOnStudent();
                statistics.GameCode = gameCode;
               
               /// data.Statistics = new StatisticsOnStudentDTO();
                var week = db.Users.ToList().FirstOrDefault(s => s.ID == userId).Classes.FirstOrDefault().
                    Weeks.LastOrDefault();
                statistics.WordErrors = week.Words.Select(w=>new WordError { WordId=w.WordCode}).ToList();
                int code = db.Users.FirstOrDefault(u => u.ID == userId).UserCode;
                statistics.StudentCode = code;
                db.StatisticsOnStudents.Add(statistics);
                data.Words = Converters.WordConverter.ConvertWordListToDTO(week.Words.ToList());
                data.Statistics = Converters.StatisticsOnStudentConverter.ConvertStatisticsToDTO(statistics);

                return data;
            }
        }

        //שליפת כל המילים
        public static List<WordDTO> GetAllWords()
        {

            using (PlayListEntities db = new PlayListEntities())
            {
                return Converters.WordConverter.ConvertWordListToDTO(db.Words.ToList());
            }
        }
    }
}
