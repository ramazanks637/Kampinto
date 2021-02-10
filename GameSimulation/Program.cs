using GameSimulation.Campaign;
using GameSimulation.Store;
using System;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1;
            player1.NationalityId = "12345678910";
            player1.FirstName = "Fatih";
            player1.LastName = "Kürekçi";
            player1.YearOfBirth = "2002";

            PlayerManager playerManager = new PlayerManager();
            Console.WriteLine("**********KAYIT EKRANI**********");
            playerManager.Register(player1);
            Console.WriteLine("**********BİLGİ GÜNCELLEME EKRANI**********");
            playerManager.Update(player1);
            Console.WriteLine("**********HESAP SİLME EKRANI**********");
            playerManager.Delete(player1);



            GameManager gameManager = new GameManager();
            Console.WriteLine("**********OYUN EKLEME EKRANI**********");
            gameManager.Add(new Game() {Id = 1, Name = "GTA V", Price = 499.99, ReviewScore = 8.3 });
            gameManager.Add(new Game() { Id = 2, Name = "PES 2021 Season Update", Price = 199.99, ReviewScore = 9.1 });
            gameManager.Add(new Game() { Id = 3, Name = "Euro Truck Simulator 2", Price = 19.99, ReviewScore = 7.8 });

            Console.WriteLine("**********OYUN GÜNCELLEME EKRANI**********");
            gameManager.Update("GTA V");
            gameManager.Update("PES 2021 Season Update");
            gameManager.Update("Euro Truck Simulator 2");

            Console.WriteLine("**********OYUN SİLME EKRANI**********");
            gameManager.Delete("GTA V");
            gameManager.Delete("PES 2021 Season Update");
            gameManager.Delete("Euro Truck Simulator 2");


            ICampaignService campaignService = new ICampaignService();


        }
    }
}
