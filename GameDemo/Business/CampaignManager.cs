using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business
{
    class CampaignManager : IManager
    {
        Campaign _campaign;

        public CampaignManager(Campaign campaign)
        {
            _campaign = campaign;
        }
        public void Add()
        {
            Console.WriteLine(_campaign.Name + " adlı kampanya eklendi");
        }

        public void Delete()
        {
            Console.WriteLine(_campaign.Name + " adlı kampanya silindi");
        }

        public void Update()
        {
            Console.WriteLine(_campaign.Name + " adlı kampanya güncellendi");
        }
    }
}
