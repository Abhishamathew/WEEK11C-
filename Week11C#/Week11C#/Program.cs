// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week11C_.Models.Entities;

namespace Week11CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new MMABooksContext();

            var customers = dbContext.Customers;

            // Display the customers
            foreach (var customer in customers)

            {

                Console.WriteLine(customer.Name);

            }
        }
    }
}


