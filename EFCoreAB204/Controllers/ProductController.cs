using Business.Services.Abstracts;
using Business.Services.Concretes;
using EFCoreAB204.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAB204.Controllers;

public class ProductController
{
    IProductService _productService = new ProductService();

    public void CreateProduct() 
    {
        Console.WriteLine("Enter product name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter product desc: ");
        string desc = Console.ReadLine();

        Console.WriteLine("Enter product price: ");
        int price = int.Parse(Console.ReadLine());

        Product product = new Product
        {
            Name = name,
            Description = desc,
            Price = price
        };

        _productService.AddProduct(product);
    }
}
