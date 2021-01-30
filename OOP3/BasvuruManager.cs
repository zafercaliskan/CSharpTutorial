using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //(IKrediManager krediManager, List<ILoggerService> loggerServices) - dependency injection
        //Method injection -> yani hangi kredi türü olacağı hangi loglayıcı olacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)            
        {
            //Burada başvuru işlemlerimde hangi kredi, hangi logger olduğu yok. Sadece soyut halleri var somut hallerini enjekte ediyoruz.

            //KonutKrediManager konutKrediManager = new KonutKrediManager(); Yanlış bir kullanım.
            //Doğru kullanım. Buraya Taşıt, konut, ihtiyac kredisiin hangisi gelirse hangisinin 
            //referansı onun bellekteki hesapla methodu çalışır.
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}