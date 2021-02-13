using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Önce varlıklarınızı bulun.
            //--
            //Burası çalışabilmek için doğrulama micro service'ine ihtiyaç duyuyor.
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());

            //gamerManager.Add(new Gamer
            //{
            //    Id = 1,
            //    BirthYear = 1995,
            //    FirstName = "Zafer",
            //    LastName = "Çalışkan",
            //    IdentityNumber = 123456789
            //});

            var gamer = new Gamer
            {
                Id = 1,
                BirthYear = 1995,
                FirstName = "Zafer",
                LastName = "Çalışkan",
                IdentityNumber = 123456789
            };

            var game = new Game
            {
                Id = 1,
                Name = "CSGO",
                Price =100
            };
            var campaign = new Campaign
            {
                Id=1,
                Name="30TL indirim",
                DiscountAmount=30
            };

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer, game, campaign);

        }
    }
}
