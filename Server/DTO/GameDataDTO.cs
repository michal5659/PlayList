using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class GameDataDTO
    {
        public List<WordDTO> Words { get; set; }
        public StatisticsOnStudentDTO Statistics { get; set; }
    }
}
