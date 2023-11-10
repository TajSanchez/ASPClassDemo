using ASPClassDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPClassDemo
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();

        public Product GetProduct(int id);

        public void UpdateProduct(Product product);

        public Product AssignCategory();

        public void InsertProduct(Product productToInsert);

        public void DeleteProduct(Product product);
    }



}
