using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new PlayerValidation());
            Player player = new Player();
            player.Id = 1;
            player.Tc = "111111111111";
            player.Name = "Eren";
            player.NickName = "AbsinThec";
            player.SurName = "Ugur";
            player.YearOfBirth = "1999";
            playerManager.Add(player);



            ProductManager productManager = new ProductManager();
            Product game = new Product();
            game.Id = 1;
            game.Name = "CS:GO";
            game.Price = 80;

            Product game2 = new Product();
            game2.Id = 2;
            game2.Name = "Blazing Sails";
            game2.Price = 20;

            Product[] products = new Product[] { game, game2 };
          



            productManager.Sell(game,player);

            PromotionManager promotionManager = new PromotionManager();
            Promotion promotion = new Promotion();
            promotion.PromotionName = "Yaz Kampanyası";
            promotion.Id = 1;
            promotion.Percent = 50;
            promotionManager.Add(promotion);
            promotionManager.Promote(promotion,products);

        }
    }
}