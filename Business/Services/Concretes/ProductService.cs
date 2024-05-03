using Business.Services.Abstracts;
using Core.RepositoryAbstracts;
using Data.RepositoryConcretes;
using EFCoreAB204.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concretes;

public class ProductService : IProductService
{
    IProductRepository _repository = new ProductRepository();
    public void AddProduct(Product product)
    {
        _repository.Add(product);
        _repository.Commit();
    }

    public void DeleteProduct(int id)
    {
        var existProduct = _repository.Get(x=>x.Id == id);
        if (existProduct == null) throw new NullReferenceException();

        _repository.Delete(existProduct);
        _repository.Commit();
    }

    public Product Get(Func<Product, bool> func = null)
    {
        return _repository.Get(func);
    }

    public List<Product> GetAll(Func<Product, bool> func = null)
    {
        return _repository.GetAll(func);
    }

    public void UpdateProduct(int id, Product newProduct)
    {
        var oldProduct = _repository.Get(x => x.Id == id);
        if (oldProduct == null) throw new NullReferenceException();

        oldProduct.Name = newProduct.Name;
        oldProduct.Description = newProduct.Description;
        oldProduct.Price = newProduct.Price;
        _repository.Commit();
    }
}
