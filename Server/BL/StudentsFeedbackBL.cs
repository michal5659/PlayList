using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StudentsFeedbackBL
    {
        //זמן למשחק לתלמיד
        public static TimeSpan TimeForStudent(TimeSpan time, int codeGame)
        {
            return time;
        }

        //מספר טעויות במשחק לתלמיד
        public static int ErrorsForStudent(int numErrors, int codeGame)
        {
            return numErrors;
        }

        //מספר הצלחות
        public static int SuccessesForStudent(int numOfSuccesses)
        {
            return 1;
        }
    }
}
