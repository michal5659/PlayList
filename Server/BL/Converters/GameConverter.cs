using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public static class GameConverter
    {
        public static Game ConvertGameToDAL(GameDTO game)
        {
            return new Game
            {
                GameCode = game.GameCode,
                GameName = game.GameName,
                MinAgeLayer = game.MinAgeLayer,
                MaxAgeLayer = game.MaxAgeLayer,
                Instructions = game.Instructions,
                Link = game.Link
            };
        }

        public static GameDTO ConvertGameToDTO(Game game)
        {
            return new GameDTO
            {
                GameCode = game.GameCode,
                GameName = game.GameName,
                MinAgeLayer = game.MinAgeLayer,
                MaxAgeLayer = game.MaxAgeLayer,
                Instructions = game.Instructions,
                Link = game.Link
            };
        }

        public static List<GameDTO> ConvertGameListToDTO(List<Game> games)
        {
            return games.Select(g => ConvertGameToDTO(g)).ToList();
        }
    }
}
