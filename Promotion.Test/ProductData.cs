using Promotion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion.Test
{
    public class  ProductData
    {
        public static List<Product> ReturnCart1()
        {
            List<Product> cart1 = new List<Product>();
            cart1.Add(new Product("A"));
            cart1.Add(new Product("B"));
            cart1.Add(new Product("C"));

            return cart1;
        }
        public static List<Product> ReturnCart2()
        {
            List<Product> cart1 = new List<Product>();
            cart1.Add(new Product("A"));
            cart1.Add(new Product("A"));
            cart1.Add(new Product("A"));
            cart1.Add(new Product("A"));
            cart1.Add(new Product("A"));
            cart1.Add(new Product("B"));
            cart1.Add(new Product("B"));
            cart1.Add(new Product("B"));
            cart1.Add(new Product("B"));
            cart1.Add(new Product("B"));
            cart1.Add(new Product("C"));

            return cart1;
        }

        public static List<Product> ReturnCart3()
        {
            List<Product> cart1 = new List<Product>();
            cart1.Add(new Product("A"));
            cart1.Add(new Product("A"));
            cart1.Add(new Product("A"));
            cart1.Add(new Product("B"));
            cart1.Add(new Product("B"));
            cart1.Add(new Product("B"));
            cart1.Add(new Product("B"));
            cart1.Add(new Product("B"));
            cart1.Add(new Product("C"));
            cart1.Add(new Product("D"));
            return cart1;
        }
    }
}
