using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class WordCategoryBL
    {
        //שליפת מילים לפי קטגוריה
        public static List<WordDTO> GetWordInCategory(int categoryCode)
        {
            using (PlayListEntities db = new PlayListEntities())
            {
                var wordList = db.Words.Where(w => w.CategoryCode == categoryCode);
                return Converters.WordConverter.ConvertWordListToDTO(wordList.ToList());
            }
        }
    }
}
