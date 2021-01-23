using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
     //encapsule
        public void Add(Product product)//101
        {
            Console.WriteLine(product.ProductName + " eklendi.");
       

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "guncellendi.");
        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Topla2(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
