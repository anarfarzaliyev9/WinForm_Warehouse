using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
   public class Seller
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Customer> customers=new List<Customer>();
        public List<Product> products = new List<Product>();
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

    }
}
