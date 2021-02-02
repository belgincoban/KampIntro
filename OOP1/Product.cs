using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //ürün aşağıda bu ürüne ait özellikler bulunmaktadır.
    {
        public int Id { get; set; } //ürün id'si
        public int CategoryId { get; set; } //hangi kategoriye ait olduğu
        public string ProductName { get; set; } //ürünün ismi
        public double UnitPrice { get; set; } // ürün birim fiyatı
        public int UnitsInStock { get; set; } // stok adedi


    }
}
