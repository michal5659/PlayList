using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StatisticsOnStudentBL
    {
        public int TeacherCode { get; set; }
        //זמן למשחק לתלמיד
        public static TimeSpan TimeForStudent(TimeSpan time, int codeGame)
        {
            return time;
        }
        //מספר טעויות במשחק לתלמיד
        public static StatisticDiagram ErrorsForStudent(int weekNum, int classCode)
        {
            StatisticDiagram diagram = new StatisticDiagram();
            using (PlayListEntities db = new PlayListEntities())
            {
                var week = db.Classes.Where(c => c.ClassCode == classCode).FirstOrDefault().
                    Weeks.FirstOrDefault(w => w.Week1 == weekNum);

                var words =week.Words;

                diagram.Labels = words.Select(w => w.Word1).ToList();

                diagram.SubLabels.AddRange(new List<string>{"מספר כשלונות לכיתה ","מספר כשלונות ארצי"});

                var allClassUsers = db.Classes.FirstOrDefault(u => u.ClassCode == classCode).Users.Where(t => t.Teacher == null);
                var weeksWordStatistics = allClassUsers.SelectMany(u => u.StatisticsOnStudents).
                         Where(s => s.Week.Week1 == weekNum).SelectMany(w=>w.WordErrors).ToLookup(w=>w.WordId);
               
              
                foreach (var w in words)
                {

                    int  wordClassVal =(int)weeksWordStatistics[w.WordCode].ToList().Average(e=>e.NumErrors);
                    int allErrorWords = (int)db.WordErrors.Where(err => err.WordId == w.WordCode).Average(e=>e.NumErrors);
                    diagram.Values.Add(new List<int> { wordClassVal, allErrorWords });

                }

                return diagram;

            }
        }
        // מספר פעמים בהם טעה באותה מילה בכלל המשחקים
        public static int ErrorsPerWordInGame(string word, int ErrorsForWord)
        {
            return 1;
        }
        //מספר הצלחות
        public static int SuccessesForStudent(int numOfSuccesses)
        {
            return 1;
        }
        //זמן ממוצע לכלל המשחקים באותו השבוע לתלמיד
        public static TimeSpan TimeForStudentsInAllTheGames(TimeSpan time, TimeSpan time2, TimeSpan time3)
        {
            return time;
        }
        // מספר טעויות כולל לתלמיד
        public static int ErrorsForStudentInAllTheGames(int numErrors1, int numErrors2, int numErrors3)
        {
            return 1;
        }
        //מספר הצלחות כולל לתלמיד
        public static int SuccessesForStudentInAllTheGames(int numOfSuccesses1, int numOfSuccesses2, int numOfSuccesses3)
        {
            return 1;
        }
        //זמן ממוצע לכלל הכיתה במשחק
        public static TimeSpan AvgTimeForClassInOneGame(TimeSpan time, TimeSpan time2, TimeSpan time3, int codeClass, int codeGame)
        {
            return time;
        }
        //זמן ממוצע לכיתה בכלל המשחקים
        public static TimeSpan AvgTimeForClassInAllTheGames(TimeSpan time, TimeSpan time2, TimeSpan time3, int codeClass)
        {
            return time;
        }
        //טעות למילה לכלל הכיתה
        public static int ErrorsPerWordInGameForClass(string word, int ErrorsForWord, int codeClass)
        {
            return 1;
        }
        //מספר הצלחות כולל לכיתה במשחק
        public static int SuccessesForClassInOneGame(int numOfSuccesses, int codeClass, int codeGame)
        {
            return 1;
        }
        //מספר הצלחות כולל לכיתה בכלל המשחקים
        public static int SuccessesForClassInAllTheGames(int numOfSuccesses, int codeClass)
        {
            return 1;
        }
        //מספר הטעויות לכלל הכיתה במשחק
        public static int ErrorsForClassInOneGame(int numErrors, int codeClass, int codeGame)
        {
            return 1;
        }
        //מספר הטעויות לכיתה בכלל המשחקים
        public static int ErrorsForClassInAllTheGame(int numErrors, int codeClass)
        {
            return 1;
        }
    }
}
