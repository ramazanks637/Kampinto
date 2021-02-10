using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    public class PlayerManager
    {
        public void Register(Player gamer)
        {
            Console.WriteLine("Kayıt İşlemin Başarıyla Tamamlandı! Aramıza Hoş Geldin " + gamer.FirstName + " :)");
        }

        public void Update(Player gamer)
        {
            Console.WriteLine("Bilgilerin Başarıyla Güncellendi " + gamer.FirstName + "!");
        }

        public void Delete(Player gamer)
        {
            Console.WriteLine("Hesabın Silindi! Kendine İyi Bak " + gamer.FirstName + " :(");
        }
    }
}
