using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class BProducto
    {
        public List<Product> GetAllProduct()
        {
            List<Product> products = new List<Product>();

            products = DProduct.Get();

            return products;
        }

        public Product GetByid(int id)
        {
            var products = DProduct.Get();
            Product product = products.Where(x => x.ProductId == id).FirstOrDefault();

            return product;
        }

        public void Update(Product product)
        {
            DProduct.Update(product);
        }

        public void Delete(int Id)
        {
            DProduct.Delete(Id);
        }
    }
}
