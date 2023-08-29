using ProductMicroservice.Data;
using ProductMicroservice.Model;
using ProductMicroservice.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ProductMicroservice.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetProductList()
        {
            return StaticProductData.Products;
        }

        public Product GetProductById(int id)
        {
            return StaticProductData.Products.FirstOrDefault(x => x.ProductId == id);
        }

        public Product AddProduct(Product product)
        {
            // Add your logic to add a new product to the static data
            return product;
        }

        public Product UpdateProduct(Product product)
        {
            // Add your logic to update a product in the static data
            return product;
        }

        public bool DeleteProduct(int Id)
        {
            // Add your logic to delete a product from the static data
            return false; // Return appropriate result
        }
    }
}
