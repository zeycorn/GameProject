using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player) == true)
            {
                Console.WriteLine("Kullanıcı eklendi.");
            } else
            {
                Console.WriteLine("Kullanıcı doğrulanamadı.");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kullanıcı güncellendi.");        
        }
    }
}
