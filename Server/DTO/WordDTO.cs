using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WordDTO
    {
        public int WordCode { get; set; }
        public string Word { get; set; }
        public string HebrewTranslation { get; set; }
        public int LayerNumber { get; set; }
        public int CategoryCode { get; set; }
    }
}
