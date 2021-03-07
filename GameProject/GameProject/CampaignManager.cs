using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " Oyunu Eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Oyun Silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Oyun Güncellendi..");
        }


        }
}
