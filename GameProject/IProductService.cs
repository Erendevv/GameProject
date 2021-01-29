using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IProductService
    {
     
        void Sell(Product product,Player player);
    }
}
