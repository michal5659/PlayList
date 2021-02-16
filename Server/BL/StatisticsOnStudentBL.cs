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

        //מספר טעויות במשחק לתלמיד
        public static StatisticDiagram ErrorsForClassWeek(int weekNum, int classCode)
        {
            StatisticDiagram diagram = new StatisticDiagram();
            using (PlayListEntities db = new PlayListEntities())
            {
                var week = db.Classes.Where(c => c.ClassCode == classCode).FirstOrDefault().
                    Weeks.FirstOrDefault(w => w.Week1 == weekNum);

                var words = week.Words;

                diagram.Labels = words.Select(w => w.Word1).ToList();


                var allClassUsers = db.Classes.FirstOrDefault(u => u.ClassCode == classCode).Users.Where(t => t.Teacher == null);
                var weeksWordStatistics = allClassUsers.SelectMany(u => u.StatisticsOnStudents).
                         Where(s => s.Week.Week1 == weekNum).SelectMany(w => w.WordErrors).ToLookup(w => w.WordId);


                diagram.Values.Add(new Data { label = "מספר כשלונות לכיתה ", data = new List<int>() });
                diagram.Values.Add(new Data { label = "מספר כשלונות ארצי", data = new List<int>() });

                foreach (var w in words)
                {

                    int wordClassVal = (int)weeksWordStatistics[w.WordCode].ToList().Average(e => e.NumErrors);
                    int allErrorWords = (int)db.WordErrors.Where(err => err.WordId == w.WordCode).Average(e => e.NumErrors);
                    diagram.Values[0].data.Add(wordClassVal);
                    diagram.Values[1].data.Add(wordClassVal);

                }


                return diagram;

            }
        }

        public static StatisticDiagram ErrorsForClassCategory(int classCode)
        {
            StatisticDiagram diagram = new StatisticDiagram();
            using (PlayListEntities db = new PlayListEntities())
            {
                var weeks = db.Classes.Where(c => c.ClassCode == classCode).FirstOrDefault().
                    Weeks;

                var categories = TeacherBL.GetCategoryListForClass(classCode);

                diagram.Labels = categories.Select(w => w.CategoryName).ToList();


                var allClassUsers = db.Classes.FirstOrDefault(u => u.ClassCode == classCode).Users.Where(t => t.Teacher == null);
                var categoryWordStatistics = allClassUsers.SelectMany(u => u.StatisticsOnStudents).
                        SelectMany(w => w.WordErrors).ToLookup(w => w.Word.CategoryCode);


                diagram.Values.Add(new Data { label = "מספר כשלונות לקטגוריה ", data = new List<int>() });

                foreach (var c in categories)
                {


                    diagram.Values[0].data.Add(categoryWordStatistics[c.CategoryCode].Sum(e => e.NumErrors));

                }


                return diagram;

            }
        }

        public static StatisticDiagram ErrorsForStudentCategory(int studentCode)
        {
            StatisticDiagram diagram = new StatisticDiagram();
            using (PlayListEntities db = new PlayListEntities())
            {
                var student = db.Users.Where(c => c.UserCode == studentCode).FirstOrDefault();


                var categories = TeacherBL.GetCategoryListForClass(student.Classes.FirstOrDefault().ClassCode);
                diagram.Labels = categories.Select(w => w.CategoryName).ToList();



                var categoryWordStatistics = student.StatisticsOnStudents.
                        SelectMany(w => w.WordErrors).ToLookup(w => w.Word.CategoryCode);


                diagram.Values.Add(new Data { label = "מספר כשלונות לקטגוריה ", data = new List<int>() });

                foreach (var c in categories)
                {


                    diagram.Values[0].data.Add(categoryWordStatistics[c.CategoryCode].Sum(e => e.NumErrors));

                }


                return diagram;

            }
        }


        public static StatisticDiagram ErrorsForStudentWeek(int studentCode)
        {
            StatisticDiagram diagram = new StatisticDiagram();
            using (PlayListEntities db = new PlayListEntities())
            {
                var student = db.Users.Where(c => c.UserCode == studentCode).FirstOrDefault();

                var weeks = TeacherBL.GetWeekListForClass(student.Classes.FirstOrDefault().ClassCode);
                diagram.Labels = weeks.Select(w => w.Week.ToString()).ToList();



                var weeklyStatistics = student.StatisticsOnStudents.
                        SelectMany(w => w.WordErrors).ToLookup(w => w.StatisticsOnStudent.Week.WeekCode);


                diagram.Values.Add(new Data { label = "מספר כשלונות שבועי ", data = new List<int>() });

                foreach (var w in weeks)
                {


                    diagram.Values[0].data.Add(weeklyStatistics[w.WeekCode].Sum(e => e.NumErrors));

                }


                return diagram;

            }
        }


        public static StatisticDiagram ErrorsForClassWeek(int classCode)
        {
            StatisticDiagram diagram = new StatisticDiagram();
            using (PlayListEntities db = new PlayListEntities())
            {


                var ww = TeacherBL.GetWeekListForClass(classCode);

                diagram.Labels = ww.Select(w => w.Week.ToString()).ToList();


                var allClassUsers = db.Classes.FirstOrDefault(u => u.ClassCode == classCode).Users.Where(t => t.Teacher == null);
                var categoryWordStatistics = allClassUsers.SelectMany(u => u.StatisticsOnStudents).
                        SelectMany(w => w.WordErrors).ToLookup(w => w.StatisticsOnStudent.Week.WeekCode);


                diagram.Values.Add(new Data { label = "מספר כשלונות שבועי ", data = new List<int>() });

                foreach (var w in ww)
                {


                    diagram.Values[0].data.Add(categoryWordStatistics[w.WeekCode].Sum(e => e.NumErrors));

                }


                return diagram;

            }



        }

        // מספר פעמים בהם טעה באותה מילה בכלל המשחקים
    }
}
