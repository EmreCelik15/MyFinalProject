using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            Console.WriteLine(categoryManager.GetById(2).Data.CategoryName);
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetAll().Data;
                if (true)
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item.ProductName + " "  + " " + item.ProductID );
                }
            }
            else
            {
                Console.WriteLine(result.Count);
            }
            
        }
    }
}
