using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface ISalesManager
    {
        int CalculateDiscountedPrice(Game game, Campaign campaign);
        void Buy();
    }
}
