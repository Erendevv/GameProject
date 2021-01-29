using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class PlayerManager : IPlayerService
    {

        IPlayerValidation _playerValidation;

        public PlayerManager(IPlayerValidation playerValidation)
        {
            _playerValidation = playerValidation;
        }
        public void Add(Player player)
        {
            if (_playerValidation.Validate(player))
            {
                Console.WriteLine(player.Name + " sisteme eklendi");
                
            }
            else
            {
                Console.WriteLine("Kimlik numaranız eşleşmiyor");
            }
             
            
           
          
        }

        public void Delete(Player player)
        {
            if (_playerValidation.Validate(player))
            {
                Console.WriteLine(player.Name + " sistemden silindi");
            }
      
        }

        public void Update(Player player)
        {
            if (_playerValidation.Validate(player))
            {
                Console.WriteLine(player.Name + " güncellendi");
            }
    
        }
    }
}
