using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StatisticsOnStudentDTO
    {
        public int GameForStudentCode { get; set; }
        public int WeekCode { get; set; }
        public int StudentCode { get; set; }
        public int GameCode { get; set; }
        public System.TimeSpan Time { get; set; }
        public Nullable<int> Errors { get; set; }
        public Nullable<int> ErrorsForWord { get; set; }
        public Nullable<int> NumOfSuccesses { get; set; }
        public Nullable<int> NumOfCorrections { get; set; }
    }
}
