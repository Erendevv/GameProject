using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class PlayerValidation : IPlayerValidation
    {
        public bool Validate(Player player)
        {
            if (player.Tc == "111111111111")
            {
                return true;
            }
            return false;
        }
    }
}
