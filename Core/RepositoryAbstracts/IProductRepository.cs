using EFCoreAB204.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryAbstracts;

public interface IProductRepository
{
    void Add(Product product);
    void Delete(Product product);

    int Commit();
    Product Get(Func<Product,bool> predicate = null);
    List<Product> GetAll(Func<Product, bool> predicate = null);
}
