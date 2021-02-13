using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        public void Sales(Gamer gamer, Game game, Campaign campaign);
    }
}
