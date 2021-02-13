using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sales(Gamer gamer, Game game, Campaign campaign)
        {
            int price=game.Price;
            if (campaign != null)
            {
                price = game.Price - campaign.DiscountAmount;
            }

            Console.WriteLine($"{game.Name} oyunu {gamer.FirstName} adlı kişiye {campaign.DiscountAmount}TL indirim ile {price}TL'ye satılmıştır.");
        }
    }
}