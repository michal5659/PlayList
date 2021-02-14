using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class StatisticDiagram
    {
        public List<string> Labels { get; set; } = new List<string>();
        public List<string> SubLabels { get; set; } = new List<string>();
        public List<List<int>> Values { get; set; } = new List<List<int>>();

    }
}
