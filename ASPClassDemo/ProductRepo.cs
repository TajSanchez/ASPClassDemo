using ASPClassDemo.Models;
using Dapper;
using System.Data;

namespace ASPClassDemo;

public class ProductRepo : IProductRepo
{
    private readonly IDbConnection _conn;

    public ProductRepo(IDbConnection conn)
    {
        _conn = conn;
    }


    public IEnumerable<Product> GetAllProducts()
    {
        return _conn.Query<Product>("SELECT * FROM products;");
    }

    public Product GetProduct(int id)
    {
        return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id", 
            new { id = id });
    }
}



