using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1; 
            customer1.CustomerNum = "123456";
            customer1.Name = "metehan";
            customer1.Surname = "mete";
            customer1.TcNum = "12345678922";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.TaxNum = "0230213213";
            customer2.CustomerNum = "132141";
            customer2.CoorporateName = "Kodlama.io";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}