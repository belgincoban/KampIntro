using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager // ürünle ilgili operasyonlar bulunmaktadır(toplama, ekle güncelle vs.) .

    {
        public void Add(Product product) //ekle
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }
    }
}
