using EcommerceConsole.Dto;
using EcommerceConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceConsole.Services
{
    public class MyServices
    {
        public Customer Customer { set; get; }

        public void Create()
        {

            Customer = new Customer
            {
                Name = "Dimitris",
                Address = "Athens",
                RegistrationDate = new DateTime(),
                Balance = 0
            };
            using (EcommerceDbContent db = new EcommerceDbContent())
            {
                db.Customers.Add(Customer);
                db.SaveChanges();
            }
            

        }

        public void Read(int id)
        {
            using EcommerceDbContent db = new EcommerceDbContent();
            Customer = db.Customers.Find(id);
        }

        public void Update(CustomerDto customerDto, int id)
        {
            if (customerDto == null) return;
            using EcommerceDbContent db = new EcommerceDbContent();
            Customer = db.Customers.Find(id);
            if (Customer != null)
            {
                if (customerDto.Name != null) Customer.Name = customerDto.Name;
                if (customerDto.Address != null) Customer.Address = customerDto.Address;
            }

            db.SaveChanges();
        }
        public void Delete(int id)
        {
            using EcommerceDbContent db = new EcommerceDbContent();
            Customer = db.Customers.Find(id);
            if (Customer != null) {
                db.Customers.Remove(Customer);
            }
            
            db.SaveChanges();
        }

    }
}
