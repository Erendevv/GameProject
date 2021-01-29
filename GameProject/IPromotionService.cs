using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IPromotionService
    {
        void Add(Promotion promotion);
        void Delete(Promotion promotion);

        void Update(Promotion promotion);
    }
}
