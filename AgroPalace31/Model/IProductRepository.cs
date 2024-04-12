using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AgroPalace31.Model
{
    public interface IProductRepository
    {
        //getting all products
        IEnumerable<Product> AllProducts { get;}
        IEnumerable<Product> ProductsOfTheWeek { get; }
        Product GetProductById(int id);

    }
}
