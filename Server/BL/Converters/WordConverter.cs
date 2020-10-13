using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public static class WordConverter
    {
        public static Word ConvertWordToDAL(WordDTO word)
        {
            return new Word
            {
                WordCode = word.WordCode,
                Word1 = word.Word,
                HebrewTranslation = word.HebrewTranslation,
                LayerNumber = word.LayerNumber,
                CategoryCode = word.CategoryCode
            };
        }

        public static WordDTO ConvertWordToDTO(Word word)
        {
            return new WordDTO
            {
                WordCode = word.WordCode,
                Word = word.Word1,
                HebrewTranslation = word.HebrewTranslation,
                LayerNumber = word.LayerNumber,
                CategoryCode = word.CategoryCode
            };
        }

        public static List<WordDTO> ConvertWordListToDTO(List<Word> words)
        {
            return words.Select(w => ConvertWordToDTO(w)).ToList();
        }
    }
}
