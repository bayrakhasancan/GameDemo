using GameDemo.Business;
using GameDemo.Entity;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member() { Id = 1, Name = "Hasan Can", LastName = "Bayrak", TCNumber = "11111111111", BirthYear = new DateTime(1997, 9, 2) };
            Game game = new Game() { Id = 1, Name = "ABC", Price = 10 };
            Campaign campaign = new Campaign() { Id = 1, Name = "%10", Rate = 10 };



            MemberManager memberManager = new MemberManager(member, new MemberCheckManager());
            memberManager.Add();
           

            CampaignManager campaignManager = new CampaignManager(campaign);
            campaignManager.Add();

            SalesManager salesManager = new SalesManager(member, game, campaign);
            salesManager.Buy();
        }
    }
}
