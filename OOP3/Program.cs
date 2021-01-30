using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface onu implemente eden class'ın referansını tutabilir.

            ////KonutKrediManager konutKrediManager = new KonutKrediManager();
            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ////IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //IKrediManager ihtiyacKrediManager =new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            ////TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();


            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            
            BasvuruManager basvuruManager = new BasvuruManager();
            //Önemli nokta. BasvuruYap(IKrediManager) yani KonutKrediManager, IhtiyacKrediManager, TasitKrediManager alabilir.
                      
            //Burada tasit kredisi yerine ihtiyacda gönderebilirdik veya herhangi bir kredi türünüde veya logger türünü de
            //Bu yazılımda sürdürülebilirliği sağlar.
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { konutKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            //Sürdürülebilirlik ispatı: SOLID (O) -> Sisteme yeni bir kod klendiğinde mevcut kodlar bozulmaz.
            //Esnaf kredisi eklersin IKrediManager'dan miras alır. Ve implement eder hesapla kodlarını yazarız.
            //Sms logger eklerkende ILoggerService'den miras alır. Log methodunu implent'e eder kodlarını yazar ve kullanırız. 
            //Ve hiçbir yerde değişiklik yapmaya gerek duymayız.

        }
    }
}