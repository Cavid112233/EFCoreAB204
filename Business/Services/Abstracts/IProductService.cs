using EFCoreAB204.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstracts;

public interface IProductService
{
    void DeleteProduct(int id);
    void AddProduct(Product product);
    void UpdateProduct(int id, Product newProduct);

    Product Get(Func<Product,bool> func = null);
    List<Product> GetAll(Func<Product,bool> func = null);
}
