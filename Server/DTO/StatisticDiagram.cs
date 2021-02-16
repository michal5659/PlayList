using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Data
    {
        public List<int> data { get; set; } = new List<int>();

        public string label { get; set; }
    }
    public class StatisticDiagram
    {


        public List<string> Labels { get; set; } = new List<string>();
        public List<Data> Values { get; set; } = new List<Data>();

    }
}
