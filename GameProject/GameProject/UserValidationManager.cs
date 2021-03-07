using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if(player.Name=="Zeynep" && player.LastName=="Çıtlak" && player.IdendityNo==11111 && player.BirthDate == 1997)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
