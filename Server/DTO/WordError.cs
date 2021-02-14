using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class WordErrorDto
    {
        public int WordId { get; set; }
        public int StatistictToStudentsId { get; set; }
        public int NumErrors { get; set; }
    }
}
