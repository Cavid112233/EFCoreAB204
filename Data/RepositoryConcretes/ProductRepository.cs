using Core.RepositoryAbstracts;
using EFCoreAB204.DAL;
using EFCoreAB204.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConcretes;

public class ProductRepository : IProductRepository
{
    AppDbContext _appDbContext = new AppDbContext();
    public void Add(Product product)
    {
        _appDbContext.Products.Add(product);
    }

    public void Delete(Product product)
    {
        _appDbContext.Products.Remove(product);
    }

    public Product Get(Func<Product, bool> predicate = null) //x=>x.Id == 1
    {
        //if(predicate == null)
        //{
        //    return _appDbContext.Products.FirstOrDefault();
        //}
        //else
        //{
        //    return _appDbContext.Products.FirstOrDefault(predicate);
        //}

        return predicate == null ?
            _appDbContext.Products.FirstOrDefault() :
            _appDbContext.Products.FirstOrDefault(predicate);
    }

    public List<Product> GetAll(Func<Product, bool> predicate = null)  // x>x.Price > 1000
    {
        return predicate == null ?
            _appDbContext.Products.ToList() :
            _appDbContext.Products.Where(predicate).ToList();
    }

    public int Commit()
    {
        return _appDbContext.SaveChanges();
    }
}
