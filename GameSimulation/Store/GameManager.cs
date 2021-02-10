using GameSimulation.Campaign;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Store
{
    public class GameManager
    {
        List<Game> games = new List<Game>() { };

        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine("{0} İsimli Oyun Kütüphanene Eklendi! İyi Oyunlar :)", game.Name);
        }

        public void Update(string GameName2)
        {
            foreach (var game in games)
            {
                if (game.Name == GameName2)
                {
                    Console.WriteLine("{0} İsimli Oyun Güncellendi!", game.Name);
                    break;
                }

                else
                {
                    continue;
                }
            }
        }

        public void Delete(string GameName)
        {
            foreach (var game in games)
            {
                if (game.Name == GameName)
                {
                    games.Remove(game);
                    Console.WriteLine("{0} İsimli Oyun Kütüphanenden Silindi!", game.Name);
                    break;
                }

                else
                {
                    continue;
                }
            }
        }
    }
}
