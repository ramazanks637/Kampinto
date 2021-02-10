using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran Bilgilerini Değerlendirme
            //
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {  
                kredi.Hesapla();
            }
        }

        public void CokluLogYap(List<ILoggerService> loglar)
        {
            foreach (var log in loglar)
            {
                log.Log();
            }
        }
    }
}
