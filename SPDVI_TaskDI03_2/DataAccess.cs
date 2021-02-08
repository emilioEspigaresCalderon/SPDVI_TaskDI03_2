using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDVI_TaskDI03_2
{
    class DataAccess
    {
        public static ProductModel GetProductModel(int ProductModelId)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AdventureWorks2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, ProductPhoto.LargePhoto FROM Production.ProductModel JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID WHERE Product.ProductModelID = {ProductModelId}";
                var productModel = conn.Query<ProductModel>(sql).FirstOrDefault();
                return productModel;
            }
        }
    }
}
