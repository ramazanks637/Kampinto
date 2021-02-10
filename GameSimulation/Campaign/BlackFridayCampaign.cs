using GameSimulation.Store;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Campaign
{
    public class BlackFridayCampaign : ICampaignService
    {
        public void AddCampaign(Game game)
        {
            game.Price -= game.Price * (0.15);
            Console.WriteLine("{0} İsimli Oyuna Black Friday Kampanyası Uygulandı.\nYeni Fiyat:{1} TL\n", game.Name, game.Price);
        }
    }
}
