using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.BirthDate = 1997; 
            player1.IdendityNo = 11111;
            player1.Name = "Zeynep";
            player1.LastName = "Çıtlak";

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "COD";


            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(player1);

            SaleManager saleManager = new SaleManager(new CampaignManager());
            saleManager.Sale(player1,campaign1);

        }
    }
}
