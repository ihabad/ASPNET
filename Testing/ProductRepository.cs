using Dapper;
using Org.BouncyCastle.Crypto.Prng.Drbg;
using System.Collections.Generic;
using System.Data;
using Testing.Models;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}
