using EcommerceConsole.Dto;
using EcommerceConsole.Services;
using System;

namespace EcommerceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction t = new Transaction();
            t.CreateData();
            t.DoSale();
            Console.WriteLine("Ok");

        }


        static void test1()
        {
            MyServices myServices = new MyServices();
            myServices.Read(2);

            if (myServices.Customer != null)
            {
                Console.WriteLine(
                                   $"Id= {myServices.Customer.Id} name= {myServices.Customer.Name}");

            }
            else
            {
                Console.WriteLine("no such customer");
            }


            myServices.Delete(20);

            CustomerDto customerDto = new CustomerDto
            {
                Address = "Arta"
            };

            myServices.Update(customerDto, 1);
            myServices.Read(1);
            Console.WriteLine(
               $"Id= {myServices.Customer.Id} " +
               $"name= {myServices.Customer.Name} " +
               $"address= {myServices.Customer.Address}");

        }
    }
}
