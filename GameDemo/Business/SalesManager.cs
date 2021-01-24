using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business
{
    class SalesManager : ISalesManager
    {
        private Member _member;
        private Game _game;

        public int LastPrice { get; set; }

        public SalesManager(Member member, Game game)
        {
            _member = member;
            _game = game;
            LastPrice = game.Price;
        }

        public SalesManager(Member member, Game game, Campaign campaign)
        {
            _member = member;
            _game = game;
            LastPrice = CalculateDiscountedPrice(game,campaign);
        }

        public int CalculateDiscountedPrice(Game game, Campaign campaign)
        {
            return game.Price - (game.Price * campaign.Rate / 100);
        }

        public void Buy()
        {
            Console.WriteLine(_member.Name + " ," + _game.Name + " adlı oyunu satın aldığınız için teşekkürler");
        }
    }
}
