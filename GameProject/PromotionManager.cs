using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PromotionManager : IPromotionService
    {
        public void Add(Promotion promotion)
        {
            Console.WriteLine(promotion.PromotionName + " isimli kampanya eklendi");
        }

        public void Delete(Promotion promotion)
        {
            Console.WriteLine(promotion.PromotionName + " isimli kampanya silindi");
        }

        public void Update(Promotion promotion)
        {
            Console.WriteLine(promotion.PromotionName + " isimli kampanya güncellendi");
        }
        public void Promote(Promotion promotion, Product[] products)

            
        {

            foreach (var product in products)
            {
                Console.WriteLine(promotion.PromotionName + " isimli kampanya " + product.Name +" ürününe uygulandı ");
            }
  
        }
    }
}
