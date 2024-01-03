using System;

namespace OOP1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategotyId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 10;

            Product product2 = new Product {Id =2,CategotyId=3,ProductName="kalem",UnitPrice=5,UnitsInStock=100};
       
        }
    }
}