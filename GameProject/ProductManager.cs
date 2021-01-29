using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class ProductManager : IProductService
    {

       
        public void Sell(Product product,Player player)
        {

            Console.WriteLine(product.Name + " adlı oyun " + player.Name + "'e satıldı");

      
        }
    }
}
