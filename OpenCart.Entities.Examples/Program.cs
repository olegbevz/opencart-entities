﻿using System;
using System.Linq;

namespace OpenCart.Entities.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var openCartDomain = new OpenCartDomain())
                {
                    var products = openCartDomain.Products.Include("Manufacturer")
                        .Where(product => product.Manufacturer.Name == "Casio")
                        .ToArray();

                    var orders = openCartDomain.Orders.ToArray();

                    var customerAddress = openCartDomain.Customers.FirstOrDefault().Address;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
