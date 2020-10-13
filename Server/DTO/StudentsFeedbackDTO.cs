using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentsFeedbackDTO
    {
        public int FeedbackCode { get; set; }
        public int StudentCode { get; set; }
        public int WordCode { get; set; }
        public int Score { get; set; }
    }
}
