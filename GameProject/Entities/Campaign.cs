using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountAmount { get; set; }
    }
}
