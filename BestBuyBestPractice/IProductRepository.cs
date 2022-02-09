using System;
using System.Collections.Generic;

namespace BestBuyBestPractice
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(); //method
        void CreateProduct(string name, double price, int categoryID); //method

    }

}
