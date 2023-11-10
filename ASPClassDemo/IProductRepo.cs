using ASPClassDemo.Models;

namespace ASPClassDemo
{
    public interface IProductRepo
    {
        public IEnumerable<Product>GetAllProducts();

        public Product GetProduct(int id);

        public void UpdateProduct(Product product);

    }



}
