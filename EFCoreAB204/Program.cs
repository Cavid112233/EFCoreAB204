using EFCoreAB204.Controllers;
using EFCoreAB204.DAL;

namespace EFCoreAB204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductController productController = new ProductController();

            productController.CreateProduct();

        }
    }
}
