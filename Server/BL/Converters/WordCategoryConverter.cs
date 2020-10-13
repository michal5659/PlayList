using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public static class WordCategoryConverter
    {
        public static WordCategory ConvertWordCategoryToDAL(WordCategoryDTO wordCategory)
        {
            return new WordCategory
            {
                CategoryCode = wordCategory.CategoryCode,
                CategoryName = wordCategory.CategoryName,
                MasterCategoryCode = wordCategory.MasterCategoryCode
            };
        }

        public static WordCategoryDTO ConvertWordCategoryToDTO(WordCategory wordCategory)
        {
            return new WordCategoryDTO
            {
                CategoryCode = wordCategory.CategoryCode,
                CategoryName = wordCategory.CategoryName,
                MasterCategoryCode = wordCategory.MasterCategoryCode
            };
        }

        public static List<WordCategoryDTO> ConvertWordCategoryListToDTO(List<WordCategory> wordCategories)
        {
            return wordCategories.Select(wc => ConvertWordCategoryToDTO(wc)).ToList();
        }
    }
}
