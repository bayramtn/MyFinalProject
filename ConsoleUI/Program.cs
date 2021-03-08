using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //EfOrderDalTest();
            //CategoryTest(2);

            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }























            Console.ReadLine();

        }

        private static void CategoryTest(int id)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            Console.WriteLine(categoryManager.GetById(id).CategoryName);

            //foreach (var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}
        }

        private static void EfOrderDalTest()
        {
            EfOrderDal efOrderDal = new EfOrderDal();
            foreach (var order in efOrderDal.GetAll(o => o.OrderId == 11077))
            {
                Console.WriteLine(order.CustomerId);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName+":"+product.CategoryName);

            }
        }
    }
}
