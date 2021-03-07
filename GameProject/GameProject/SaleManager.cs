using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager:ISaleService
    {
        ICampaignService _campaignService;

        public SaleManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Sale(Player player,Campaign campaign)
        {
                Console.WriteLine(player.Name +" kişisi "+campaign.CampaignName+" oyununu satın aldı.");            
        }
    }
}
