using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GameDTO
    {
        public int GameCode { get; set; }
        public string GameName { get; set; }
        public int MinAgeLayer { get; set; }
        public int MaxAgeLayer { get; set; }
        public string Instructions { get; set; }
        public string Link { get; set; }
    }
}
