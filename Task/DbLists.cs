using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public class DbLists
    {

        public static List<Seller> sellers = new List<Seller>() {
           new Seller()
        {
            Username = "john",
            Password = "123",

            Name = "John",

            Surname = "Wick",

        },
        new Seller()
        {
              Username = "lucy",
              Password = "1234",
              Name = "Lucy",

             Surname = "Green",

        }
        };
        public void AddSeller(Seller seller)
        {
            sellers.Add(seller);
        }






    }
}
